using Microsoft.AspNetCore.Mvc;

namespace ExperimentFive.Controllers
{
    public class AboutController : Controller
    {
        [Route("About")]
        public IActionResult Index() => View();
    }
}