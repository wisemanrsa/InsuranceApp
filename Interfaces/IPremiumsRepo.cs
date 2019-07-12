using System.Collections.Generic;
using insuranceApp.Models;
using InsuranceApp.Models;

namespace InsuranceApp.Interfaces
{
    public interface IPremiumsRepo
    {
         List<OwnPremium> GetMembersPremium();
         List<OtherPremium> GetNonMembersPremium();
         OtherPremium CalculateNonMembersPremium(int sumInsuredId);
         OwnPremium CalculateMembersPremium(int sumInsuredId);
         void SavePremium(PremiumsHistory premium);
    }
}