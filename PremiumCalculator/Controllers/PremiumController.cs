using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PremiumCalculator.Models;
using System.Collections.Generic;

namespace PremiumCalculator.Controllers
{
    public class PremiumController : Controller
    {
        [Route("/")]
        public IActionResult Calculator()
        {
            var model = new PremiumViewModel() { OccupationList = new List<SelectListItem>() };
            return View(model);
        }

    }
}
