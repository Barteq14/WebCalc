using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCalc.DAO;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    public class BmiController : Controller
    {
        private readonly WebCalcContext _context;
        public static double bmi;
        public BmiController(WebCalcContext context)
        {
            _context = context;
        }
        public IActionResult Index(double bmi2)
        {

            bmi2 = Math.Round(bmi, 2);
            ViewBag.BMI = bmi2;
         /*  
            var query = _context.Results.Select(b => b.BMI);
            foreach (var item in query)
            {
                bmi = item;
            }
         */
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ReadForm(double weight, double height)
        {
           
            ViewBag.w = weight;
            ViewBag.h = height/100;
            double height2 = Math.Pow(height, 2);
            bmi = (weight / height2) * 10000;
         
            return RedirectToAction("Index",bmi);
     
        }
    }
}
