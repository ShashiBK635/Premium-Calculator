﻿using Microsoft.AspNetCore.Mvc.Rendering;
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
        public string DOB { get; set; }

        public List<SelectListItem> OccupationList { get; set; }

        [Required]
        [MinLength(1)]
        public string Occupation { get; set; }

        [Required]
        [Range(1,int.MaxValue)]
        public int SumInsured { get; set; }

        [DisplayFormat(DataFormatString = "{0:#,##0.00}")]
        public double DeathPremium { get; set; }

        [DisplayFormat(DataFormatString = "{0:#,##0.00}")]
        public double TPDPremiumMonthly { get; set; }

    }
}
