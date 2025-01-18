using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luval.HealthMate.Fitbit.Models
{
    public class NutritionalValues
    {
        public int? Biotin { get; set; }
        public int? Calcium { get; set; }
        public int? Calories { get; set; }
        public int? CaloriesFromFat { get; set; }
        public int? Cholesterol { get; set; }
        public int? Copper { get; set; }
        public int? DietaryFiber { get; set; }
        public int? FolicAcid { get; set; }
        public int? Iodine { get; set; }
        public int? Iron { get; set; }
        public int? Magnesium { get; set; }
        public int? Niacin { get; set; }
        public int? PantothenicAcid { get; set; }
        public int? Phosphorus { get; set; }
        public int? Potassium { get; set; }
        public int? Protein { get; set; }
        public int? Riboflavin { get; set; }
        public int? SaturatedFat { get; set; }
        public int? Sodium { get; set; }
        public int? Sugars { get; set; }
        public int? Thiamin { get; set; }
        public int? TotalCarbohydrate { get; set; }
        public int? TotalFat { get; set; }
        public int? TransFat { get; set; }
        public int? VitaminA { get; set; }
        public int? VitaminB12 { get; set; }
        public int? VitaminB6 { get; set; }
        public int? VitaminC { get; set; }
        public int? VitaminD { get; set; }
        public int? VitaminE { get; set; }
        public int? Zinc { get; set; }

        public List<KeyValuePair<string, string>> CreateKeyValue()
        {
            var keyValuePairs = new List<KeyValuePair<string, string>>();

            if (Biotin.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("biotin", Biotin.Value.ToString()));
            if (Calcium.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("calcium", Calcium.Value.ToString()));
            if (Calories.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("calories", Calories.Value.ToString()));
            if (CaloriesFromFat.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("caloriesFromFat", CaloriesFromFat.Value.ToString()));
            if (Cholesterol.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("cholesterol", Cholesterol.Value.ToString()));
            if (Copper.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("copper", Copper.Value.ToString()));
            if (DietaryFiber.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("dietaryFiber", DietaryFiber.Value.ToString()));
            if (FolicAcid.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("folicAcid", FolicAcid.Value.ToString()));
            if (Iodine.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("iodine", Iodine.Value.ToString()));
            if (Iron.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("iron", Iron.Value.ToString()));
            if (Magnesium.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("magnesium", Magnesium.Value.ToString()));
            if (Niacin.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("niacin", Niacin.Value.ToString()));
            if (PantothenicAcid.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("pantothenicAcid", PantothenicAcid.Value.ToString()));
            if (Phosphorus.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("phosphorus", Phosphorus.Value.ToString()));
            if (Potassium.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("potassium", Potassium.Value.ToString()));
            if (Protein.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("protein", Protein.Value.ToString()));
            if (Riboflavin.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("riboflavin", Riboflavin.Value.ToString()));
            if (SaturatedFat.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("saturatedFat", SaturatedFat.Value.ToString()));
            if (Sodium.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("sodium", Sodium.Value.ToString()));
            if (Sugars.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("sugars", Sugars.Value.ToString()));
            if (Thiamin.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("thiamin", Thiamin.Value.ToString()));
            if (TotalCarbohydrate.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("totalCarbohydrate", TotalCarbohydrate.Value.ToString()));
            if (TotalFat.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("totalFat", TotalFat.Value.ToString()));
            if (TransFat.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("transFat", TransFat.Value.ToString()));
            if (VitaminA.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("vitaminA", VitaminA.Value.ToString()));
            if (VitaminB12.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("vitaminB12", VitaminB12.Value.ToString()));
            if (VitaminB6.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("vitaminB6", VitaminB6.Value.ToString()));
            if (VitaminC.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("vitaminC", VitaminC.Value.ToString()));
            if (VitaminD.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("vitaminD", VitaminD.Value.ToString()));
            if (VitaminE.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("vitaminE", VitaminE.Value.ToString()));
            if (Zinc.HasValue) keyValuePairs.Add(new KeyValuePair<string, string>("zinc", Zinc.Value.ToString()));

            return keyValuePairs;
        }
    }
}
