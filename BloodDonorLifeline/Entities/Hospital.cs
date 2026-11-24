namespace BloodDonorLifeline.Entities
{
    public class Hospital : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public required string Address { get; set; }
        public Guid AreaId { get; set; }
        public Area Area { get; set; } = null!;
        public bool IsVerified { get; set; } = false;

        public ICollection<BloodRequest> BloodRequests { get; set; } = [];
    }
}
