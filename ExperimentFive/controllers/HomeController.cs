using Microsoft.AspNetCore.Mvc;

namespace ExperimentFive.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home")]
        public IActionResult Index() => View();
    }
}