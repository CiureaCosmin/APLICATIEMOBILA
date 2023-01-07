namespace API.Models
{
    public class Appointments
    {
        public string Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public DateTime DateTime { get; set; }
        public string UserId { get; set; }
        public string SalonId { get; set; }
        public int ServiceId { get; set; }
        public bool? Confirmed { get; set; }
        public bool? IsSalonRatedByTheUser { get; set; }
    }
}
