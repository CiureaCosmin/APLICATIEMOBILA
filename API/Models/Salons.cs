using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Salons
    {
        public string Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        [Column("Rating")]
        public double Rating { get; set; }
        public string? OwnerId { get; set; }
        public int RatersCount { get; set; }
    }
}
