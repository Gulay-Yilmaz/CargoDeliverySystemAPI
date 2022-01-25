using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.CarrierOperations.Commands
{
    public class UpdateCarrierCommandViewModel
    {
        public int Id { get; set; }
        public decimal NewLatitude { get; set; }
        public decimal NewLongitude { get; set; }
        public string cargoName { get; set; }
    }
}
