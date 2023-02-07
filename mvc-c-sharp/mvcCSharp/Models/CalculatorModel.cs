using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvcCSharp.Models
{
    public class CalculatorModel
    {
        [Required]
        [Range(0, 100)]
        public short assignments { get; set; }
        [Required]
        [Range(0, 100)]
        public short project { get; set; }
        [Required]
        [Range(0, 100)]
        public short quizzes { get; set; }
        [Required]
        [Range(0, 100)]
        public short midterm { get; set; }
        [Required]
        [Range(0, 100)]
        public short final { get; set; }
        [Required]
        [Range(0, 100)]
        public short intex { get; set; }
    }
}