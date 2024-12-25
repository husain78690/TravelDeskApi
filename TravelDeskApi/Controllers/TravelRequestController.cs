using Microsoft.AspNetCore.Mvc;
using TravelDeskApi.IRepo;
using TravelDeskApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelDeskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelRequestController : ControllerBase
    {
        ITravelRequestRepository _repo;
        public TravelRequestController(ITravelRequestRepository travelRequestRepository)
        {
            _repo = travelRequestRepository;
        }
        // GET: api/<TravelRequestController>



        // GET api/<TravelRequestController>/5
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetTravelRequest());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repo.GetTravelRequestById(id));
        }

        // POST api/<TravelRequestController>
        [HttpPost]
        public IActionResult Post(TravelRequest travelRequest)
        {
            _repo.ADDTravelRequest(travelRequest);
            return Created("Traval added", travelRequest);
        }

        // PUT api/<TravelRequestController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id,TravelRequest travelRequest)
        {
            _repo.UpdateTravelRequest(id,travelRequest);
            return Ok();
        }

        // DELETE api/<TravelRequestController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repo.DELETEDTravelRequest(id);
            return Ok();
        }
    }
}
