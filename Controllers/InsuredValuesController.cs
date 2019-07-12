using insuranceApp.Models;
using InsuranceApp.Dto;
using InsuranceApp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceApp.Controllers
{
    public class InsuredValuesController : Controller
    {
        private readonly IPremiumsService premiumsService;
        public InsuredValuesController(IPremiumsService premiumsService)
        {
            this.premiumsService = premiumsService;
        }

        [HttpGet("/api/insured-values")]
        public IActionResult GetInsuredValues()
        {
            var insuredValues = premiumsService.GetSumInsured();
            return Ok(insuredValues);
        }

        [HttpPost("/api/premium")]
        public IActionResult CalculatePremium([FromBody] PremiumCalcDto dto)
        {
            if (dto.Age < 18 || dto.Age > 65) return BadRequest("Only 18 to 65 years old can take up a policy");
            return Ok(premiumsService.CalculateMembersPremium(dto));
        }

        [HttpGet("/api/premium")]
        public IActionResult GetHistories(int? id)
        {
            return Ok(premiumsService.GetHistory(id));
        }
    }
}