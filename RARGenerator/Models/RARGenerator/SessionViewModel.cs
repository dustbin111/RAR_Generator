namespace RARGenerator.Models
{
    public class SessionViewModel
    {
        public SessionViewModel()
        {
            WarningBanner = new WarningBanner();
            Facility = new Facility();
            System = new System();
        }



        public WarningBanner WarningBanner { get; set; }
        public Facility Facility { get; set; }
        
        public System System { get; set; }

        public Threats Threats { get; set; }
    }
}