using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiLayer.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class DemoapiController : ControllerBase
    {
        // GET: api/<DemoapiController>
        [HttpGet]
        [Route("GetDet")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DemoapiController>/5
        [HttpGet("GetbyId/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DemoapiController>
        [HttpPost("send")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DemoapiController>/5
        [HttpPut("update/{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DemoapiController>/5
        [HttpDelete("delete/{id}")]
        public void Delete(int id)
        {
        }
    }
}
