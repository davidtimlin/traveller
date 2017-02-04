using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Traveller.Domain
{
    public class Proposal
    {
        [Key]
        public int ProposalId { get; set; }

        [Required]
        [Display(Name = "Proposal name")]
        [StringLength(50, ErrorMessage = "Proposal name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        public virtual Country Country { get; set; }

        public virtual List<Vote> Votes { get; set; }
    }
}
