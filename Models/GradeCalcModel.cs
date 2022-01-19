using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission1.Models
{
    public class GradeCalcModel
    {
        [Required]
        [Range(0, 100)]
        public int assigment { get; set; }
        [Required]
        [Range(0, 100)]
        public int project { get; set; }
        [Required]
        [Range(0, 100)]
        public int quizzes { get; set; }
        [Required]
        [Range(0, 100)]
        public int exam { get; set; }
        [Required]
        [Range(0, 100)]
        public int intex { get; set; }

    }
}
