using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_SignUpLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SignUpLab.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            ViewBag.CountryList = new List<CountryModel> { new CountryModel { Country = "India", CountryCode = "IND" },
                new CountryModel { Country="USA",CountryCode="USA"},new CountryModel{Country="Austrilia",CountryCode="AUS"}
                };
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.CountryList = new List<CountryModel> { new CountryModel { Country = "India", CountryCode = "IND" },
                new CountryModel { Country="USA",CountryCode="USA"},new CountryModel{Country="Austrilia",CountryCode="AUS"}
                };
            return View();
        }

        [HttpGet]
        public JsonResult GetCitiName(string CountryCode)
        {
            IEnumerable<CityModel> Cities = new CityModel().GetCitiNames().Where(x => x.CountryCode == CountryCode).ToList();

            return Json(new SelectList(Cities, "CityCode", "City"));
        }
    }
}
