using System.Collections.Generic;
using System.Linq;
using InsuranceApp.Dto;
using InsuranceApp.Interfaces;

namespace InsuranceApp.Services
{
    public class PremiumsService : IPremiumsService
    {
        private readonly IPremiumsRepo premiumsRepo;
        public PremiumsService(IPremiumsRepo premiumsRepo)
        {
            this.premiumsRepo = premiumsRepo;

        }
        public List<InsuredValuesDto> GetSumInsured()
        {
            var insuredValues = new List<InsuredValuesDto>();
            var memberValues = premiumsRepo.GetMembersPremium();
            var nonMembersValues = premiumsRepo.GetNonMembersPremium();

            memberValues.ToList().ForEach(val => insuredValues.Add(new InsuredValuesDto{Id = val.Id, Value = val.SumInsured, IsMember = true}));
            nonMembersValues.ToList().ForEach(val => insuredValues.Add(new InsuredValuesDto{Id = val.Id, Value = val.SumInsured, IsMember = false}));
            
            return insuredValues;
        }
    }
}