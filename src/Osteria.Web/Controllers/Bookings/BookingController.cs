using Microsoft.AspNetCore.Mvc;
using Osteria.Web.Models;

namespace Osteria.Web.Presentation.Controllers.Bookings
{
    public class BookingController : Controller
    {
        [Route("/bookings")]
        public IActionResult Index()
        {
            ViewBag.Users = new List<UserViewModel>()
            {
                new UserViewModel()
                {
                    Name = "Humberto",
                    Surname = "Filho",
                    Email = "hleitefilho@hotmail.com",
                },
                new UserViewModel()
                {
                    Name = "Bruna",
                    Surname = "Oliveira",
                    Email = "bruninha.oliv@hotmail.com",
                },
                new UserViewModel()
                {
                    Name = "Selma",
                    Surname = "Silva Francano",
                    Email = "onca@hotmail.com",
                },
                new UserViewModel()
                {
                    Name = "Humberto",
                    Surname = "Lisboa Leite",
                    Email = "vader@hotmail.com",
                },
            };

            return View();
        }
    }
}
