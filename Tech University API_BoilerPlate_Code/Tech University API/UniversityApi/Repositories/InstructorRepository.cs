using System.Collections.Generic;
using System.Linq;
using UniversityApi.Data;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Repositories
{
    public class InstructorRepository : IInstructor
    {
        private readonly UniversityDbContext _context;

        public InstructorRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public bool AddInstructor(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
            return true;
        }

        // Instructors having more than X courses
        public IEnumerable<Instructor> GetInstructorsWithCourseCountAbove(int count)
        {
            return _context.Instructors
                .Where(i => i.InstructorCourses.Count > count)
                .ToList();
        }

        // Instructors with highest enrollments across all courses
        public IEnumerable<Instructor> GetInstructorsWithMostEnrollments()
        {
            var data = _context.Instructors
                .Select(i => new
                {
                    Instructor = i,
                    TotalEnrollments = i.InstructorCourses
                        .Sum(ic => ic.Course.Enrollments.Count)
                })
                .ToList();

            var max = data.Max(x => x.TotalEnrollments);

            return data
                .Where(x => x.TotalEnrollments == max)
                .Select(x => x.Instructor)
                .ToList();
        }
    }
}