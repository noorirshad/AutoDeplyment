using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoDeplyment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoDeployController : ControllerBase
    {
     
        [HttpGet]
        [Route("get-success")]
        public IActionResult GetMessage()
        {
            return Ok("Success");
        }
    }
}
