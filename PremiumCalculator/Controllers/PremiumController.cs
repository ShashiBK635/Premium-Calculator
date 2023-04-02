using Microsoft.AspNetCore.Mvc;
using PremiumCalculator.Common;
using PremiumCalculator.Models;
using System;

namespace PremiumCalculator.Controllers
{
    public class PremiumController : Controller
    {
        [Route("/")]
        public IActionResult Calculator()
        {
            var model = new PremiumViewModel() { OccupationList = PremiumUtility.GetOccupations() };
            return View(model);
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Calculator(PremiumViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.DeathPremium = PremiumUtility.CalculateDeathPremium(model);
                model.TPDPremiumMonthly = PremiumUtility.CalculateTPDPremiumMonthly(model);
            }
            else
            {
                model.DeathPremium = 0;
                model.TPDPremiumMonthly = 0;
            }

            model.OccupationList = PremiumUtility.GetOccupations();
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
