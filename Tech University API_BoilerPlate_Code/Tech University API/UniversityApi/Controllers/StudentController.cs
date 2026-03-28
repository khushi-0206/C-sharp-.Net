using Microsoft.AspNetCore.Mvc;
using UniversityApi.Interfaces;

namespace UniversityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _studentService;

        public StudentController(IStudent studentService)
        {
            _studentService = studentService;
        }

        // DELETE STUDENT
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var result = _studentService.DeleteStudent(id);

            if (!result)
                return NotFound("Student not found");

            return Ok("Student deleted successfully");
        }

        // GET STUDENTS BY COURSE TITLE
        [HttpGet("by-course/{title}")]
        public IActionResult GetStudentsByCourseTitle(string title)
        {
            var students = _studentService.GetStudentsByCourseTitle(title);

            return Ok(students);
        }
    }
}