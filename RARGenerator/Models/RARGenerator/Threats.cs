using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RARGenerator.Models
{
    public class Threats
    {
        public string ThreatEvent { get; set; }
        public string ThreatReference { get; set; }
        public string ThreatCategory { get; set; }
        public string ThreatVulnerability { get; set; }
        public string ThreatMitigation { get; set; }
        public string ThreatLikelihood { get; set; }
        public string ThreatImpact { get; set; }
        public string ThreatRisk { get; set; }
    }
}