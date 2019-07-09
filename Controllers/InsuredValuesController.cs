using insuranceApp.Models;
using InsuranceApp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceApp.Controllers
{
    [Route("api/[controller]")]
    public class InsuredValuesController : Controller
    {
        private readonly InsuranceDbContext context;
        private readonly IPremiumsService premiumsService;
        public InsuredValuesController(IPremiumsService premiumsService)
        {
            this.premiumsService = premiumsService;
        }

        [HttpGet]
        public IActionResult GetInsuredValues()
        {
            var insuredValues = premiumsService.GetSumInsured();
            return Ok(insuredValues);
        }
    }
}