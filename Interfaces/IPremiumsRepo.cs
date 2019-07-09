using System.Collections.Generic;
using insuranceApp.Models;

namespace InsuranceApp.Interfaces
{
    public interface IPremiumsRepo
    {
         List<OwnPremium> GetMembersPremium();
         List<OtherPremium> GetNonMembersPremium();
    }
}