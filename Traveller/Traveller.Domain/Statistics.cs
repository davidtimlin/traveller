using System.ComponentModel.DataAnnotations;

namespace Traveller.Domain
{
    public class Statistics
    {
        [Key]
        public int StatisticsId { get; set; }

        [Display(Name = "Cities bagged")]
        public int CitiesVisited { get; set; }

        [Display(Name = "Museum count")]
        public int MuseumsVisited { get; set; }

        [Display(Name = "Trip highlight")]
        public string Highlight { get; set; }
    }
}
