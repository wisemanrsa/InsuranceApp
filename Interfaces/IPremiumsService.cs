using System.Collections.Generic;
using InsuranceApp.Dto;

namespace InsuranceApp.Interfaces
{
    public interface IPremiumsService
    {
         List<InsuredValuesDto> GetSumInsured();
    }
}