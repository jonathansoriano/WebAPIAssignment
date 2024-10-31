using Microsoft.AspNetCore.Mvc;
using WebAPIAssignment.Models;

namespace WebAPIAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JonController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            Jon jon = new Jon("Jon Sanjuan");
            return Ok(jon);
        }
    }
}
