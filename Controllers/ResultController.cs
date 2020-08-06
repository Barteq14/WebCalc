using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCalc.DAO;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    public class ResultController : Controller
    {
        private readonly WebCalcContext _context;
        public ResultController(WebCalcContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            var query = _context.Measures.Select(r => r);
            
            List<Result> res = new List<Result>();
            List<double> bf = new List<double>();
            List<double> bmi = new List<double>();
            double a,b,c,d,d2,e,resultBF = 0.0, resultBMI = 0.0;
            int idM = 0;
            foreach(var item in query)
            {
                a = 4.15 * item.Belt;
                b = a / 2.54;
                c = 0.082 * item.Weight * 2.2;
                d = b - c - 98.42;
                d2 = b - c - 76.76;
                e = item.Weight * 2.2;
                resultBF = d / e * 100;
                idM = item.ID;
                resultBMI = item.Weight / (item.Height / 100);
                //result +/- 3%
            }
            bf.Add(resultBF);
            bmi.Add(resultBMI);
            //dorobic obliczanie bmi
            res.Add(new Result { BF = bf[0], BMI = bmi[0] });

            return View(res);
        }
    }
}
