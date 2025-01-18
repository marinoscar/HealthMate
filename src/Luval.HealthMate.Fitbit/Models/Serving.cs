using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luval.HealthMate.Fitbit.Models
{
    public class Serving
    {
        public double? Multiplier { get; set; }
        public double? ServingSize { get; set; }
        public Unit? Unit { get; set; }
        public int? UnitId { get; set; }
    }
}
