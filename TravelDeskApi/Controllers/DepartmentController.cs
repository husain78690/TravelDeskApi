using Microsoft.AspNetCore.Mvc;
using TravelDeskApi.IRepo;
using TravelDeskApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelDeskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IDepartmentRepo _repo;
        public DepartmentController(IDepartmentRepo departmentRepo)
        {
            _repo = departmentRepo;
        }
        // GET: api/<DepartmentController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetDepartments());
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repo.GetDepartmentById(id));
        }

        // POST api/<DepartmentController>
        [HttpPost]
        public IActionResult Post(Department department)
        {
            _repo.ADDDepartment(department);
            return Created("Department added", department);
        }

        // PUT api/<DepartmentController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Department department)
        {
            _repo.UpdateDepartment(id, department);
            return Ok();
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repo.DELETEDepartment(id);
            return Ok();
        }
    }
}
