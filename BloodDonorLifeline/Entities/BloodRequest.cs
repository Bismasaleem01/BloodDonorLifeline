using BloodDonorLifeline.Entities.Enums;

namespace BloodDonorLifeline.Entities
{
    public class BloodRequest : BaseEntity
    {
        public Guid HospitalId { get; set; }
        public Hospital Hospital { get; set; } = null!;
        public required BloodGroup BloodGroup { get; set; }
        public required int UnitsNeeded { get; set; }
        public required UrgencyLevel Urgency { get; set; }
        public required string PatientCase { get; set; }
        public RequestStatus Status { get; set; } = RequestStatus.Open;

        public ICollection<Donation> Donations { get; set; } = [];
    }
}
