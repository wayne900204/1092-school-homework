using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web410828593.Controllers
{
    public class WaterController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string name, float? weight)
        {
            var result = "";

            if (weight.HasValue) {
                result = (weight * 30) + "cc";
            }

            ViewBag.Name = name;
            ViewBag.Result = result;
            return View();
        }
    }
}
