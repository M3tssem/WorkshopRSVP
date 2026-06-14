using System.ComponentModel.DataAnnotations;

namespace WorkshopRSVP.Models
{
    public class Rsvp
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = "";

        [Display(Name = "Needs Accommodation")]
        public bool NeedsAccommodation { get; set; }

        [Display(Name = "Workshop Title")]
        public string WorkshopTitle { get; set; } = "";
    }
}