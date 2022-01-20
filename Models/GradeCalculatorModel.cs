using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstASPNETWebAppHarris.Models
{
    public class GradeCalculatorModel
    {
        [Range(0,100)]
        public string assignmentp { get; set; }

        [Range(0, 100)]
        public string groupprojectp { get; set; }

        [Range(0, 100)]
        public string quizzesp { get; set; }

        [Range(0, 100)]
        public string examsp { get; set; }

        [Range(0, 100)]
        public string intexp { get; set; }
    }
}
