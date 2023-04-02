using Microsoft.AspNetCore.Mvc;
using PremiumCalculator.Common;
using PremiumCalculator.Models;

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

            model.OccupationList = PremiumUtility.GetOccupations();
            return View(model);
        }

    }
}
