using FirstWebAPIDemo.Models.Repo;
using Microsoft.AspNetCore.Mvc;
using FirstWebAPIDemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        StudentRepo sRepo = null;
        public StudentsController() 
        {
            sRepo = new StudentRepo();
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return sRepo.GetAll();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return sRepo.Get(id);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, Student obj)
        {
            bool res = sRepo.Update(id, obj);
            if (res)
            {
                Response.StatusCode = 200;
                Response.WriteAsync("Student Update successfully");
            }
            else
            {
                Response.StatusCode = 404;
                Response.WriteAsync("Student not found with given id");
            }
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            bool res = sRepo.Delete(id);
            if (res)
            {
                Response.StatusCode = 200;
                Response.WriteAsync("Student deleted successfully");
            }
            else
            {
                Response.StatusCode = 404;
                Response.WriteAsync("Student not found with given id");
            }
        }
    }
}
