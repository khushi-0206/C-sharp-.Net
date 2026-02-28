using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using MVC_EF_CodeFirst_Project.Models;
namespace MVC_EF_CodeFirst_Project.Data
{
    public class StudentManagementContext :DbContext
    {
        public StudentManagementContext(DbContextOptions<StudentManagementContext> options)
           : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        //public DbSet<Hostel> Hostels { get; set; }
    }
}
