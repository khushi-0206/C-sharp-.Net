using StudentPortalWebApp.Models;
namespace StudentPortalWebApp.Services
{
    public interface IStudentService
    {
        Task<List<Student>> SearchAsync(string q = null);
        Task<Student?> GetByIdAsync(int id);
        Task AddStudentAsync(Student student);
        Task UpdateStudentAsync(Student student);
        Task DeleteStudentAsync(int id);
    }
}
