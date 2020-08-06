using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCalc.DAO;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    public class MeasureController : Controller
    {
        private readonly WebCalcContext _context;
        public static double resultBF;
        public MeasureController(WebCalcContext context)
        {
            _context = context;
        }
        //GET/Measure/Index
        public IActionResult Index(double bf)
        {
            bf = resultBF;
            ViewBag.BF = bf;
            var query = _context.Measures.Select(m => m);
            List<Measure> measure = new List<Measure>();
            foreach(var item in query)
            {
                measure.Add(item);
            }
            if(query == null)
            {
                ViewBag.error = "nic nie ma w bazie danych";
                return View(ViewBag.error);
            }
            return View(measure);
        }
        //GET/Form
        public IActionResult Form()
        {
            //metoda wyswietlajaca formularz
            return View();
        }
        //POST/Form
        [HttpPost]
        public IActionResult ReadForm(Measure measure)
        {
            double a, b, c, d, d2, e;

            a = 4.15 * measure.Belt;
            b = a / 2.54;
            c = 0.082 * measure.Weight * 2.2;
            d = b - c - 98.42;
            d2 = b - c - 76.76;
            e = measure.Weight * 2.2;
            resultBF = d / e * 100;
 
            //result +/- 3%


            measure.Date = DateTime.Now;
            measure.ATime = DateTime.Now; 
            
            _context.Measures.Add(measure);
          
            _context.SaveChanges();
            
            
            return RedirectToAction("Index",resultBF);
        }

        public IActionResult Shutdown()
        {
            var query = _context.Measures.Select(m => m);
            foreach(var item in query)
            {
                _context.Remove(item);
            }

            _context.SaveChanges();
            return RedirectToAction("Index","Bmi");
        }
     
    }
}
