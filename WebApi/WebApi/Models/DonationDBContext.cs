using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    // Inherit DbContext class from Entity Framework
    public class DonationDBContext:DbContext
    {
        // Constructor to set up database connection settings
        public DonationDBContext(DbContextOptions<DonationDBContext> options) :base(options)
        {
            
        }
        
        // property of DCandidate to create corresponding table
        public DbSet<DCandidate> DCandidates { get; set; }
        
    }
}