using System.Collections.Generic;
using System.Linq;
using insuranceApp.Models;
using InsuranceApp.Interfaces;

namespace InsuranceApp.Repos
{
    public class PremiumsRepo : IPremiumsRepo
    {
        private readonly InsuranceDbContext context;
        public PremiumsRepo(InsuranceDbContext context)
        {
            this.context = context;

        }
        public List<OwnPremium> GetMembersPremium()
        {
            return context.OwnPremiums.ToList();
        }

        public List<OtherPremium> GetNonMembersPremium()
        {
            return context.OtherPremiums.ToList();
        }
    }
}