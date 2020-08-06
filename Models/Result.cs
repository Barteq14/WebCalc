using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalc.Models
{
    public class Result
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public double BMI { get; set; }
        [Required]
        public double BF { get; set; }

  
    }
}
