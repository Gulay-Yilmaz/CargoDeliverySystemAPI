using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.CarrierLogOperations.Commands
{
    public class CreateCarrierLogCommandViewModel
    {
        public int CarrierId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
