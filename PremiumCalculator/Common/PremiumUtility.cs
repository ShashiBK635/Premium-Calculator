using Microsoft.AspNetCore.Mvc.Rendering;
using PremiumCalculator.Models;
using System;
using System.Collections.Generic;

namespace PremiumCalculator.Common
{
    public static class PremiumUtility
    {
        private static double GetOccupationRatingFactor(string occupation)
        {
            var factor = 0.00;
            var rating = string.Empty;

            switch (occupation)
            {
                case Constants.Cleaner:
                case Constants.Florist:
                    rating = Constants.LightManual;
                    break;
                case Constants.Doctor:
                    rating = Constants.Professional;
                    break;
                case Constants.Author:
                    rating = Constants.WhiteCollar;
                    break;
                case Constants.Farmer:
                case Constants.Mechanic:
                    rating = Constants.HeavyManual;
                    break;
                default:
                    break;
            }

            switch (rating)
            {
                case Constants.Professional:
                    factor = 1.00;
                    break;
                case Constants.WhiteCollar:
                    factor = 1.25;
                    break;
                case Constants.LightManual:
                    factor = 1.50;
                    break;
                case Constants.HeavyManual:
                    factor = 1.75;
                    break;
                default:
                    break;
            }

            return factor;
        }

        public static List<SelectListItem> GetOccupations()
        {
            var occupations = new List<SelectListItem>();
            occupations.Add(new SelectListItem() { Text = "", Value = "" });
            occupations.Add(new SelectListItem() { Text = Constants.Cleaner, Value = Constants.Cleaner });
            occupations.Add(new SelectListItem() { Text = Constants.Doctor, Value = Constants.Doctor });
            occupations.Add(new SelectListItem() { Text = Constants.Author, Value = Constants.Author });
            occupations.Add(new SelectListItem() { Text = Constants.Farmer, Value = Constants.Farmer });
            occupations.Add(new SelectListItem() { Text = Constants.Mechanic, Value = Constants.Mechanic });
            occupations.Add(new SelectListItem() { Text = Constants.Florist, Value = Constants.Florist });

            return occupations;
        }

        public static double CalculateDeathPremium(PremiumViewModel model)
        {
            var factor = GetOccupationRatingFactor(model.Occupation);
            var premium = (model.SumInsured * factor * model.Age) / 1000 * 12;

            return Math.Round(premium, 2);
        }

        public static double CalculateTPDPremiumMonthly(PremiumViewModel model)
        {
            var factor = GetOccupationRatingFactor(model.Occupation);
            var premium = (model.SumInsured * factor * model.Age) / 1234;

            return Math.Round(premium, 2);
        }
    }
}
