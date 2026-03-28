using Microsoft.AspNetCore.Mvc;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly IInstructor _instructorService;

        public InstructorController(IInstructor instructorService)
        {
            _instructorService = instructorService;
        }

        // ADD INSTRUCTOR
        [HttpPost]
        public IActionResult AddInstructor([FromBody] Instructor instructor)
        {
            var result = _instructorService.AddInstructor(instructor);

            if (!result)
                return BadRequest("Instructor not added");

            return Ok("Instructor added successfully");
        }

        // GET INSTRUCTORS WITH COURSE COUNT ABOVE
        [HttpGet("course-count/{count}")]
        public IActionResult GetInstructorsWithCourseCountAbove(int count)
        {
            var instructors = _instructorService.GetInstructorsWithCourseCountAbove(count);

            return Ok(instructors);
        }

        // GET INSTRUCTORS WITH MOST ENROLLMENTS
        [HttpGet("most-enrollments")]
        public IActionResult GetInstructorsWithMostEnrollments()
        {
            var instructors = _instructorService.GetInstructorsWithMostEnrollments();

            return Ok(instructors);
        }
    }
}