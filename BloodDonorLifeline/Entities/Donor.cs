using BloodDonorLifeline.Entities.Enums;

namespace BloodDonorLifeline.Entities
{
    public class Donor : BaseEntity
    {
        // Link to login account
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public required string FullName { get; set; }
        public required string Phone { get; set; }
        public required BloodGroup BloodGroup { get; set; }

        // Link to area
        public Guid AreaId { get; set; }
        public Area Area { get; set; } = null!;

        public bool IsAvailable { get; set; } = true;
        public DateOnly? LastDonationDate { get; set; }
        public ICollection<Donation> Donations { get; set; } = [];
    }
}

