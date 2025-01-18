using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luval.HealthMate.Fitbit.Models
{
    public class CreateFoodResponse
    {
        public Food? Food { get; set; }
        public HttpResponseMessage? Response { get; set; }
    }
}
