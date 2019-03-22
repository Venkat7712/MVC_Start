using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Start.Models;

namespace MVC_Start.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {

      return View();
    }

    public IActionResult IndexWithLayout()
    {
      return View();
    }

    public ViewResult Guest()
        {
            GuestContact Contact = new GuestContact {
                Name = "Venkat", Email = "venkat@gmail.com", Phone = "8162938273" };
            return View(Contact);
        }

        [HttpPost]
        public ViewResult Guest (GuestContact Contact)
        {
            return View(Contact);
        }
  }
}