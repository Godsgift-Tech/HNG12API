using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNG12API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetInformation()
        {
            var response = new
            {
                email = "godsgiftoghenechohwo@gmail.com",
                currentDate = DateTime.UtcNow.ToString("o"),
                githubUrl = ""

                //return Ok("Welcome to HNG12 API");
            };
            return Ok(response);    
        }
    }
}