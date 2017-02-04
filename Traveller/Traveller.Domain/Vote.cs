using System.ComponentModel.DataAnnotations;

namespace Traveller.Domain
{
    public class Vote
    {
        [Key]
        public int VoteId { get; set; }

        public virtual Proposal Proposal { get; set; }
    }
}
