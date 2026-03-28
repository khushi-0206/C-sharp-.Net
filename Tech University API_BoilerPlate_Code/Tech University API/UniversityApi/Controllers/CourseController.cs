using Microsoft.AspNetCore.Mvc;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourse _courseService;

        public CourseController(ICourse courseService)
        {
            _courseService = courseService;
        }

        // UPDATE COURSE
        [HttpPut]
        public IActionResult UpdateCourse([FromBody] Course course)
        {
            var result = _courseService.UpdateCourse(course);

            if (!result)
                return NotFound("Course not found");

            return Ok("Course updated successfully");
        }

        // GET COURSES WITH ENROLLMENT ABOVE GRADE
        [HttpGet("by-grade/{grade}")]
        public IActionResult GetCoursesWithEnrollmentsAboveGrade(int grade)
        {
            var courses = _courseService.GetCoursesWithEnrollmentsAboveGrade(grade);

            return Ok(courses);
        }

        // GET COURSES BY INSTRUCTOR NAME
        [HttpGet("by-instructor/{name}")]
        public IActionResult GetCoursesByInstructorName(string name)
        {
            var courses = _courseService.GetCoursesByInstructorName(name);

            return Ok(courses);
        }
    }
}