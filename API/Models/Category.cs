using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("Categories")]
    public class Category
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [Column("ModifiedOn")]
        public DateTime? ModifiedOn { get; set; }

        [Column("IsDeleted")]
        public bool IsDeleted { get; set; }

        [Column("DeletedOn")]
        public DateTime? DeletedOn { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("ImageUrl")]
        public string ImageUrl { get; set; }
    }
}
