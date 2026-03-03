using StudentPortalWebApp.Models;
using StudentPortalWebApp.Repositories;

namespace StudentPortalWebApp.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;
        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }
        public Task<Student?> GetByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<List<Student>> SearchAsync(string q = null) => _repo.GetAllAsync(q);
        public async Task AddStudentAsync(Student student)
        {
            await _repo.AddAsync(student);
        }

        public async Task UpdateStudentAsync(Student student)
        {
            await _repo.UpdateAsync(student);
        }

        public async Task DeleteStudentAsync(int id)
        {
            await _repo.DeleteAsync(id);
        }

    }
}
