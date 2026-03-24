using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagement.Models;

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        // Temporary in-memory data (replace with DB later)
        private static List<StudentAdmissionDetails> students = new List<StudentAdmissionDetails>()
        {
            new StudentAdmissionDetails { StudentId = 1, StudentName = "Adam", StudentClass = "X", DateOfJoining = DateTime.Now },
            new StudentAdmissionDetails { StudentId = 2, StudentName = "Brad", StudentClass = "IX", DateOfJoining = DateTime.Now }
        };

        // ✅ 1. GET ALL
        // https://localhost:44381/api/StudentAdmission
        [HttpGet]
        public ActionResult<IEnumerable<StudentAdmissionDetails>> GetAll()
        {
            return Ok(students);
        }

        // ✅ 2. GET BY ID
        // https://localhost:44381/api/StudentAdmission/{id}
        [HttpGet("{id}")]
        public ActionResult<StudentAdmissionDetails> GetById(int id)
        {
            var student = students.FirstOrDefault(x => x.StudentId == id);

            if (student == null)
                return NotFound($"Student with ID {id} not found");

            return Ok(student);
        }

        // ✅ 3. CREATE
        // https://localhost:44381/api/StudentAdmission
        [HttpPost]
        public ActionResult<StudentAdmissionDetails> Create(StudentAdmissionDetails newStudent)
        {
            if (newStudent == null)
                return BadRequest();

            newStudent.StudentId = students.Max(x => x.StudentId) + 1;

            students.Add(newStudent);

            return CreatedAtAction(nameof(GetById), new { id = newStudent.StudentId }, newStudent);
        }

        // ✅ 4. UPDATE
        // https://localhost:44381/api/StudentAdmission/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, StudentAdmissionDetails updatedStudent)
        {
            var student = students.FirstOrDefault(x => x.StudentId == id);

            if (student == null)
                return NotFound($"Student with ID {id} not found");

            student.StudentName = updatedStudent.StudentName;
            student.StudentClass = updatedStudent.StudentClass;
            student.DateOfJoining = updatedStudent.DateOfJoining;

            return Ok(student);
        }

        // ✅ 5. DELETE
        // https://localhost:44381/api/StudentAdmission/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(x => x.StudentId == id);

            if (student == null)
                return NotFound($"Student with ID {id} not found");

            students.Remove(student);

            return Ok($"Student with ID {id} deleted successfully");
        }
    }
}