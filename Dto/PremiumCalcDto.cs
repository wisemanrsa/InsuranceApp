using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Dto
{
    public class PremiumCalcDto
    {
        [Required]
        public int Age { get; set; }
        [Required]
        public bool IsMember { get; set; }
        [Required]
        public int SumIsuredId { get; set; }
    }
}