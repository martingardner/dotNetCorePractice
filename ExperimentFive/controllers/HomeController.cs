using Microsoft.AspNetCore.Mvc;

namespace ExperimentFive.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("Home")]
        public IActionResult Index() => View();
    }
}