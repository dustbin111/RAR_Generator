using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RARGenerator.Models
{
    public class Assessors
    {
        public string AssessorTitle { get; set; }
        [Required]
        public string AssessorName { get; set; }
        public string AssessorPhone { get; set; }
        public string AssessorEmail { get; set; }
    }
}