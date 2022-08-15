using Microsoft.AspNetCore.Mvc;

namespace Osteria.Web.Presentation.Controllers.Weekends
{
    public class WeekendController : Controller
    {
        [Route("/weekends")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
