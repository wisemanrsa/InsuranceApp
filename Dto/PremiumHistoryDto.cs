using System;

namespace InsuranceApp.Dto
{
    public class PremiumHistoryDto
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int PayerId { get; set; }
        public string Name { get; set; }
        public int SumInsured { get; set; }
        public DateTime ActionDate { get; set; }
        public int Premium { get; set; }
    }
}