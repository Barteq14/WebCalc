using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalc.Models
{
    public class Measure
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public double Neck { get; set; }
        [Required]

        public double Waist { get; set; }
    
        [Required]
        public double Wrist { get; set; }

        [Required]
        public double Height { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]
        public double Belt { get; set; }

        [Required]
        public int Age { get; set; }

    
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime ATime { get; set; }

    }
}
