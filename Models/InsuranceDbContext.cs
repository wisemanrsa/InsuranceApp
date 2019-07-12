using InsuranceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace insuranceApp.Models
{
    public class InsuranceDbContext : DbContext
    {
        public InsuranceDbContext(DbContextOptions<InsuranceDbContext> options) : base(options)
        {

        }

        public DbSet<OwnPremium> OwnPremiums { get; set; }
        public DbSet<OtherPremium> OtherPremiums { get; set; }
        public DbSet<PremiumsHistory> PremiumsHistories { get; set; }
    }
}