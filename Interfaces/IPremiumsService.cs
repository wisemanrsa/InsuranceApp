using System.Collections.Generic;
using InsuranceApp.Dto;

namespace InsuranceApp.Interfaces
{
    public interface IPremiumsService
    {
         List<InsuredValuesDto> GetSumInsured();
         PremiumDto CalculateMembersPremium(PremiumCalcDto dto);
         List<PremiumHistoryDto> GetHistory(int? id);
    }
}