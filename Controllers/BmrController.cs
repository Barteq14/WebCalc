using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCalc.DAO;

namespace WebCalc.Controllers
{
    public class BmrController : Controller
    {
        private readonly WebCalcContext _context;
        public static double bmr;
        public BmrController(WebCalcContext context)
        {
            _context = context;
        }
        public IActionResult Index(double bmr2)
        {
            bmr2 = bmr;
            ViewBag.BMR = bmr2;
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ReadForm(double weight, double height, int age)
        {
            bmr = 66 + (13.7 * weight) + (5 * height) - (6.76 * age);
           
            return RedirectToAction("Index",bmr);
        }
    }
}
