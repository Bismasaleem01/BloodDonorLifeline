namespace BloodDonorLifeline.Entities
{
    public class Donation : BaseEntity
    {
        public Guid DonorId { get; set; }
        public Donor Donor { get; set; } = null!;
        public Guid? BloodRequestId { get; set; }
        public BloodRequest? BloodRequest { get; set; }
        public required DateOnly LastDonationDate { get; set; } 
    }
}
