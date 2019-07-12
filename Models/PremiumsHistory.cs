using System;
namespace InsuranceApp.Models
{
    public class PremiumsHistory
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int PayerId { get; set; }
        public string Name { get; set; }
        public int SumInsured { get; set; }
        public DateTime ActionDate { get; set; } 
    }
}