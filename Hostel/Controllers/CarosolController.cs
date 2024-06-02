using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hostel.Controllers
{
    public class CarosolController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Carousel()
        {
            var slides = new List<Carosol>
            {
                new Carosol { Id = 1, ImageUrl = "~/Uploads/Logos/image2.jpg", Caption = "Slide 1", Description = "Slide 1 description." },
                new Carosol { Id = 2, ImageUrl = "~/Uploads/Logos/image3.jpg", Caption = "Slide 2", Description = "Slide 2 description." },
                new Carosol { Id = 3, ImageUrl = "~/Uploads/Logos/image4.jpg", Caption = "Slide 3", Description = "Slide 3 description." }
            };

            return View(slides);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}