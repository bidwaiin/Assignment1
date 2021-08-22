using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Country = new List<SelectListItem>
             {
                 new SelectListItem { Value = "IN", Text = "India" },
                 new SelectListItem { Value = "CA", Text = "Canada" },
                new SelectListItem { Value = "US", Text = "USA"  },
            };

            ViewBag.Genders = new[] { "Male", "Female", "Unspecified" };
            return View();
        }

        public IActionResult getStates(string Country)
        {
            List<City> city = new List<City>
            {
                new City(){ cityId=1, countryCode="IN",cityName="Pune" },
                new City(){ cityId=2, countryCode="IN",cityName="Mumbai" },
                new City(){ cityId=3, countryCode="US",cityName="Alaska" },
                new City(){ cityId=4, countryCode="US",cityName="Florida" },
                new City(){ cityId=5, countryCode="CA",cityName="Quebec" },
                new City(){ cityId=6, countryCode="CA",cityName="Ontario" }
            };

            //states.Where(item => item.CountryCode == Country);

            return Json(city.Where(item => item.countryCode == Country));

        }

        [HttpPost]
        public IActionResult Create(SignUp signUp)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
