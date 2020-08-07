﻿using System;
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
        public static string sexx;
        public static int age;
        public MeasureController(WebCalcContext context)
        {
            _context = context;
        }
        //GET/Measure/Index
        public IActionResult Index(double bf)
        {
            bf = resultBF;
            double bf2 = Math.Round(bf, 2);
            ViewBag.BF = bf2;
            var query = _context.Measures.Select(m => m);
            ViewBag.sex = sexx;
            ViewBag.age = age;
            return View();
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
            double a, b, c, d, e;

            if (Request.Form["sex"] == "Male")
            {
                a = 4.15 * measure.Belt;
                b = a / 2.54;
                c = 0.082 * measure.Weight * 2.2;
                d = b - c - 98.42;
                e = measure.Weight * 2.2;
                resultBF = d / e * 100;
                 sexx = "Male";
                age = measure.Age;

            }
            else
            {
                a = 4.15 * measure.Belt;
                b = a / 2.54;
                c = 0.082 * measure.Weight * 2.2;
                d = b - c - 76.76;
                e = measure.Weight * 2.2;
                resultBF = d / e * 100;
                 sexx = "Female";
                age = measure.Age;
            }

           

            measure.Date = DateTime.Now;
            measure.ATime = DateTime.Now; 
            
            _context.Measures.Add(measure);
          
            _context.SaveChanges();
            
            
            return RedirectToAction("Index",resultBF);
        }
    }
}
