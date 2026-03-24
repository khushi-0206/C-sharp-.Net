using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttendenceManagement.Models;

namespace StudentAttendenceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendenceController : ControllerBase
    {
        // In-memory data (temporary)
        private static List<StudentAttendenceDetails> attendanceList = new List<StudentAttendenceDetails>()
        {
            new StudentAttendenceDetails { StudentId = 1, StudentName = "Adam", AttendencePercentage = 90 },
            new StudentAttendenceDetails { StudentId = 2, StudentName = "Brad", AttendencePercentage = 82 }
        };

        // ✅ 1. GET ALL
        // https://localhost:44317/api/StudentAttendance
        [HttpGet]
        public ActionResult<IEnumerable<StudentAttendenceDetails>> GetAll()
        {
            return Ok(attendanceList);
        }

        // ✅ 2. GET BY ID
        // https://localhost:44317/api/StudentAttendance/{id}
        [HttpGet("{id}")]
        public ActionResult<StudentAttendenceDetails> GetById(int id)
        {
            var student = attendanceList.FirstOrDefault(x => x.StudentId == id);

            if (student == null)
                return NotFound($"Student with ID {id} not found");

            return Ok(student);
        }

        // ✅ 3. CREATE
        // https://localhost:44317/api/StudentAttendance
        [HttpPost]
        public ActionResult<StudentAttendenceDetails> Create(StudentAttendenceDetails newRecord)
        {
            if (newRecord == null)
                return BadRequest();

            newRecord.StudentId = attendanceList.Max(x => x.StudentId) + 1;

            attendanceList.Add(newRecord);

            return CreatedAtAction(nameof(GetById), new { id = newRecord.StudentId }, newRecord);
        }

        // ✅ 4. UPDATE
        // https://localhost:44317/api/StudentAttendance/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, StudentAttendenceDetails updatedRecord)
        {
            var student = attendanceList.FirstOrDefault(x => x.StudentId == id);

            if (student == null)
                return NotFound($"Student with ID {id} not found");

            student.StudentName = updatedRecord.StudentName;
            student.AttendencePercentage = updatedRecord.AttendencePercentage;

            return Ok(student);
        }

        // ✅ 5. DELETE
        // https://localhost:44317/api/StudentAttendance/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = attendanceList.FirstOrDefault(x => x.StudentId == id);

            if (student == null)
                return NotFound($"Student with ID {id} not found");

            attendanceList.Remove(student);

            return Ok($"Student attendance with ID {id} deleted successfully");
        }
    }
}