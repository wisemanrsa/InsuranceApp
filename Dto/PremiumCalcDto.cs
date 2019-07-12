using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Dto
{
    public class PremiumCalcDto
    {
        public int Age { get; set; }
        public bool IsMember { get; set; }
        public int SumIsuredId { get; set; }
        public int PayerId { get; set; }
        public string PayerName { get; set; }
    }
}