using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_ev244.Models
{
    public class GradeCalcModel
    {   
        [Required]
        [Range(0, 100, ErrorMessage = "Values must be between 0 and 100")]
        public int Assignments { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Values must be between 0 and 100")]
        public int Projects { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Values must be between 0 and 100")]
        public int Quizzes { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Values must be between 0 and 100")]
        public int Midterm { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Values must be between 0 and 100")]
        public int Final { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Values must be between 0 and 100")]
        public int Intex { get; set; }

    }
}
