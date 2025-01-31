using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNG12API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        [HttpGet("Retriever")]

        public IActionResult GetInformation()
        {
            var response = new
            {
                email = "godsgiftoghenechohwo@gmail.com",
                currentDate = DateTime.UtcNow.ToString("o"),
                githubUrl = "https://github.com/Godsgift-Tech/HNG12API"

                //return Ok("Welcome to HNG12 API");
            };
            return Ok(response);    
        }
    }
}