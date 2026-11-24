namespace BloodDonorLifeline.Entities
{
    public class Area : BaseEntity
    {
        public required string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

    }
}
