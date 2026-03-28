using System.Collections.Generic;
using System.Linq;
using UniversityApi.Data;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Repositories
{
    public class StudentRepository : IStudent
    {
        private readonly UniversityDbContext _context;

        public StudentRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public bool DeleteStudent(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.StudentId == id);

            if (student == null)
                return false;

            _context.Students.Remove(student);
            _context.SaveChanges();
            return true;
        }

        // Students enrolled in a course by title
        public IEnumerable<Student> GetStudentsByCourseTitle(string title)
        {
            return _context.Students
                .Where(s => s.Enrollments
                    .Any(e => e.Course.Title == title))
                .ToList();
        }
    }
}