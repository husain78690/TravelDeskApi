using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using TravelDeskApi.Context;
using TravelDeskApi.IRepo;
using TravelDeskApi.Models;
using Project = TravelDeskApi.Models.Project;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelDeskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        IProjectsRepo _Repo;
        public ProjectController(IProjectsRepo projectRepo)
        {
            _Repo = projectRepo;
        }
        // GET: api/<ProjectController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_Repo.GetProjects());
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_Repo.GetProjectsByid(id));
        }

        // POST api/<ProjectController>
        [HttpPost]
        public IActionResult Post(Project projects)
        {
            _Repo.AddProject(projects);
            return Created("Project added", projects);
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id,Project project)
        {
            _Repo.UpdateProjects(id, project);
            return Ok();
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           _Repo.DELETEProject(id);
            return Ok();
        }
    }
}
