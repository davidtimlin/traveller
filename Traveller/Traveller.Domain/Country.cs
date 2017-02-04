using System.ComponentModel.DataAnnotations;

namespace Traveller.Domain
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        public string Name { get; set; }
    }
}
