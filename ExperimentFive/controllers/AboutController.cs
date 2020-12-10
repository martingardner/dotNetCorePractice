using Microsoft.AspNetCore.Mvc;

namespace ExperimentFive.Controllers
{
    public class AboutController : Controller
    {
        [Route("About")]
        public IActionResult Index() => View();

        [HttpGet("GetData")]
        public string GetData() => "42";   

        [HttpGet("AddAndReturn")]   
        public int AddAndReturn(
            [FromQuery] int number1, int number2
        )  => number1 + number2;
    }
}