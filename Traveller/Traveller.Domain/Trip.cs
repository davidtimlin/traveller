using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Traveller.Domain
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }

        public virtual Statistics Statistics { get; set; }

        [Required]
        [Display(Name = "Friendly name")]
        [StringLength(50, ErrorMessage = "Trip name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [Display(Name = "Trip description")]
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Trip start")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Trip end")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Purpose")]
        public TripType TripType { get; set; }

        [Range(1, 5)]
        public int? Rating { get; set; }

        public virtual List<Country> Countries { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}
