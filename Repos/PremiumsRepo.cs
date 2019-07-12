using System.Collections.Generic;
using System.Linq;
using insuranceApp.Models;
using InsuranceApp.Interfaces;
using InsuranceApp.Models;

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

        public OwnPremium CalculateMembersPremium(int sumInsuredId)
        {
            return context.OwnPremiums.FirstOrDefault(pre => pre.Id == sumInsuredId);
        }
        public OtherPremium CalculateNonMembersPremium(int sumInsuredId)
        {
            return context.OtherPremiums.FirstOrDefault(pre => pre.Id == sumInsuredId);
        }

        public void SavePremium(PremiumsHistory premium)
        {
            context.PremiumsHistories.Add(premium);
            context.SaveChanges();
        }

        public List<PremiumsHistory> GetHistory(int? payerId = null)
        {
            var premiums = context.PremiumsHistories.ToList();
            if (payerId != null)
                premiums = premiums.Where(p => p.PayerId == payerId).ToList();
            return premiums;
        }
    }
}