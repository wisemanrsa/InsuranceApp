using System;
using System.Collections.Generic;
using System.Linq;
using insuranceApp.Models;
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

            memberValues.ToList().ForEach(val => insuredValues.Add(new InsuredValuesDto { Id = val.Id, Value = val.SumInsured, IsMember = true }));
            nonMembersValues.ToList().ForEach(val => insuredValues.Add(new InsuredValuesDto { Id = val.Id, Value = val.SumInsured, IsMember = false }));

            return insuredValues;
        }

        public PremiumDto CalculateMembersPremium(int age, bool isMember, int sumInsuredId)
        {
            var memberPremiums = premiumsRepo.CalculateMembersPremium(sumInsuredId);
            var OtherPremiums = premiumsRepo.CalculateNonMembersPremium(sumInsuredId);
            var premium = GetPremium(isMember ? (object)memberPremiums : OtherPremiums, age);

            return new PremiumDto
            {
                Premium = premium
            };
        }
        public int GetPremium<T>(T o, int age)
        {
            Type type = o.GetType();
            int premium = 0;
            foreach (var f in type.GetProperties())
            {
                var values = f.Name.Replace("Field", "").Trim().Split('_');
                if (f.Name.StartsWith("Field") && age >= Convert.ToInt32(values[0]) && age <= Convert.ToInt32(values[1]))
                    return (int)f.GetValue(o);
            }
            return premium;
        }
    }
}