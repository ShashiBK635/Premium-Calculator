using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace PremiumCalculator.Models
{
    public class PremiumViewModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public List<SelectListItem> OccupationList { get; set; }
        public string Occupation { get; set; }
        public int SumInsured { get; set; }
        public double DeathPremium { get; set; }
        public double TPDPremiumMonthly { get; set; }

    }
}
