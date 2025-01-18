using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Luval.HealthMate.Fitbit.Models
{
    public class Food
    {
        public string? AccessLevel { get; set; }
        public string? Brand { get; set; }
        public int? Calories { get; set; }
        public string? CreatorEncodedId { get; set; }
        public double? DefaultServingSize { get; set; }
        public Unit? DefaultUnit { get; set; }
        public long? FoodId { get; set; }
        public bool? IsGeneric { get; set; }
        public string? Name { get; set; }
        public NutritionalValues? NutritionalValues { get; set; }
        public List<Serving>? Servings { get; set; }
        public List<int>? Units { get; set; }
    }
}
