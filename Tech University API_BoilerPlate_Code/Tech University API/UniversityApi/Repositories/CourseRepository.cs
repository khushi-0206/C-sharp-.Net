using System.Collections.Generic;
using System.Linq;
using UniversityApi.Data;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Repositories
{
    public class CourseRepository : ICourse
    {
        private readonly UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public bool UpdateCourse(Course course)
        {
            var existing = _context.Courses.FirstOrDefault(c => c.CourseId == course.CourseId);

            if (existing == null)
                return false;

            existing.Title = course.Title;

            _context.SaveChanges();
            return true;
        }

        // Courses where any student has grade > given grade
        public IEnumerable<Course> GetCoursesWithEnrollmentsAboveGrade(int grade)
        {
            return _context.Courses
                .Where(c => c.Enrollments.Any(e => e.Grade > grade))
                .ToList();
        }

        // Courses taught by instructor name (MANY-TO-MANY)
        public IEnumerable<Course> GetCoursesByInstructorName(string name)
        {
            return _context.Courses
                .Where(c => c.InstructorCourses
                    .Any(ic => ic.Instructor.Name == name))
                .ToList();
        }
    }
}