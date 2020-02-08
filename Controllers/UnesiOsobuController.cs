using OIBValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OIBValidation.Controllers
{
    public class UnesiOsobuController : Controller
    {
        // GET: UnesiOsobu
        [HttpGet]
        public ActionResult UnesiOsobu()
        {
            return View(new Osoba());
        }

        [HttpPost]
        public ActionResult UnesiOsobu(Osoba osoba)
        {
            if (ModelState.IsValid)
            {
                return View("OsobaUnjeta", osoba);                
            }
            else
            {
                return View(osoba);
            }
        }
    }
}