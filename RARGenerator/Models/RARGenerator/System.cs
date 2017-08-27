using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RARGenerator.Models
{
    public class System
    {
        [Required]
        public string SystemUID { get; set; }
        [Required]
        public string SystemName { get; set; }
        [Required]
        public string SystemDescription { get; set; }
        [Required]
        public string SystemMission { get; set; }
        [Required]
        public string SystemType { get; set; }
        [Required]
        public string SystemLocationType { get; set; }
        public string SystemLocation { get; set; }
        [Required]
        public string SystemBoundaries { get; set; }
        [Required]
        public string SystemCategorization { get; set; }
        [Required]
        public string SystemClassification { get; set; }
        [Required]
        public string SystemDataType { get; set; }

    }
}