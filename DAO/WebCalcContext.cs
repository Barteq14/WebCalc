using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCalc.Models;

namespace WebCalc.DAO
{
    public class WebCalcContext :DbContext
    {
        public WebCalcContext(DbContextOptions<WebCalcContext> options)
          : base(options)
        {
        }
        public DbSet<Measure> Measures { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
