using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PracticeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApp.Controllers
{
    public class AccountController : Controller
    {
        public List<City> lstCities = new List<City>()
        {
            new City() { CityId = 1, CityName = "Hyderabad", CountryId = 2 },
            new City() { CityId = 2, CityName = "Chennai", CountryId = 2 },
            new City() { CityId = 3, CityName = "New York", CountryId = 1 },
            new City() { CityId = 4, CityName = "California", CountryId = 1 },

        };


        public List<Country> lstCountires = new List<Country>()
        {
            new Country() { CountryId = 1, CountryName = "United States of America" },
            new Country() { CountryId = 2, CountryName = "India" }


        };
        public IActionResult SignUp()
        {
            ViewBag.CountryList = new SelectList(lstCountires, "CountryId", "CountryName");
            return View();
        }

        public JsonResult GetCityList(int CountryId)
        {
            List<City> filterCityList = lstCities.FindAll(m => m.CountryId == CountryId);
            return new JsonResult(filterCityList);
        }

        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


    }
}
