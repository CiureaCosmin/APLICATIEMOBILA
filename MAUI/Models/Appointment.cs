using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI.Models
{
    [Table("Appointments")]
 
    public class Appointment
    {
        [Column("Id")]
        public string Id { get; set; }
        [Column("CreatedOn")]
        public DateTime CreatedOn { get; set; }
        [Column("ModifiedOn")]
        public DateTime? ModifiedOn { get; set; }
        [Column("IsDeleted")]
        public bool IsDeleted { get; set; }
        [Column("DeletedOn")]
        public DateTime? DeletedOn { get; set; }
        [Column("DateTime")]
        public DateTime DateTime { get; set; }
        [Column("UserId")]
        public string UserId { get; set; }
        [Column("SalonId")]
        public string SalonId { get; set; }
        [Column("ServiceId")]
        public int ServiceId { get; set; }
        [Column("Confirmed")]
        public bool? Confirmed { get; set; }
        [Column("IsSalonRatedByTheUser")]
        public bool? IsSalonRatedByTheUser { get; set; }
    }
}
