//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RARGenerator.Models
{
    public class Facility
    {
        [Required, StringLength(5, MinimumLength = 5)]
        public string FacilityCAGE { get; set; }
        //[Required]
        public string FacilityName { get; set; }
        //[Required]
        public string FacilityAddress1 { get; set; }
        public string FacilityAddress2 { get; set; }
        //[Required]
        public string FacilityCity { get; set; }
        //[Required]
        public string FacilityState { get; set; }
        public string FacilityZIP { get; set; }
    }
}