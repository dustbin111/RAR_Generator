using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RARGenerator.Models
{
    public class RecordOfChanges
    {
        public string ChangeVersion { get; set; }
        public string ChangeDate { get; set; }
        public string ChangeSectionsModified { get; set; }
        public string ChangeDescription { get; set; }
    }
}