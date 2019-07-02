using Microsoft.EntityFrameworkCore;

namespace insuranceApp.Models
{
    public class InsuranceDbContext : DbContext
    {
        public InsuranceDbContext(DbContextOptions<InsuranceDbContext> options) : base(options)
        {

        }

        DbSet<OwnPremium> OwnPremiums { get; set; }
        DbSet<OtherPremium> OtherPremiums { get; set; }
    }
}