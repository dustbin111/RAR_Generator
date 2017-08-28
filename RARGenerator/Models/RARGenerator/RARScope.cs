using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RARGenerator.Models
{
    public class RARScope
    {
        [Required]
        public string RARPurpose { get; set; }
        [Required]
        public string RAScope { get; set; }
        [Required]
        public string RARConstraints { get; set; }
        [Required]
        public string RARTimeframe { get; set; }
        [Required]
        public string RARPeriodicReviews { get; set; }
        public string RARPeriodicReviewsFrequency { get; set; }
        [Required]
        public string RARApproach { get; set; }

    }
}