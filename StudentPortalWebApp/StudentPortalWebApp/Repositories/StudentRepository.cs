using Microsoft.EntityFrameworkCore;
using StudentPortalWebApp.Models;
namespace StudentPortalWebApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentPortalDbContext _db;
        public StudentRepository(StudentPortalDbContext db)
        {
            _db = db;
        }

        

        public async Task<List<Student>> GetAllAsync(string q = null)
        {
            var query = _db.Students.AsQueryable();
            if (!string.IsNullOrWhiteSpace(q))
            {
                q = q.Trim().ToLower();
                query = query.Where(s => s.FullName.ToLower().Contains(q) || s.Email.ToLower().Contains(q));
            }

            //Read-only list -> AsNoTracking improves performance
            return await query.AsNoTracking().OrderByDescending(s => s.CreatedAt).ToListAsync();
        }
        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _db.Students
                            .AsNoTracking()
                            .FirstOrDefaultAsync(s => s.StudentId == id);
        }
        public async Task AddAsync(Student student)
        {
            await _db.Students.AddAsync(student);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Student student)
        {
            _db.Students.Update(student);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var student = await _db.Students
                                   .Include(s => s.Enrollments) // if navigation exists
                                   .FirstOrDefaultAsync(s => s.StudentId == id);

            if (student != null)
            {
                _db.Enrollments.RemoveRange(student.Enrollments);
                _db.Students.Remove(student);
                await _db.SaveChangesAsync();
            }
        }
    }
}
