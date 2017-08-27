namespace RARGenerator.Models
{
    public class SessionViewModel
    {
        public SessionViewModel()
        {
            WarningBanner = new WarningBanner();
            Facility = new Facility();
        }



        public WarningBanner WarningBanner { get; set; }
        public Facility Facility { get; set; }
        
    }
}