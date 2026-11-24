using Microsoft.EntityFrameworkCore;

namespace BloodDonorLifeline.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options)
        {

        }

    }
}
