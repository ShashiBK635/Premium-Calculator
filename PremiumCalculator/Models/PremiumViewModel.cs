using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PremiumCalculator.Models
{
    public class PremiumViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        public List<SelectListItem> OccupationList { get; set; }
        [Required]
        [MinLength(1)]
        public string Occupation { get; set; }
        [Required]
        [Range(1,int.MaxValue)]
        public int SumInsured { get; set; }
        public double DeathPremium { get; set; }
        public double TPDPremiumMonthly { get; set; }

    }
}
