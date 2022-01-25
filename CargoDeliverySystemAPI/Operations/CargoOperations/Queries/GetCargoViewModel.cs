using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.CargoOperations.Queries
{
    public class GetCargoViewModel
    {
        public decimal latitude { get; set; } //view modelde istediğim alanları belirttim
        public decimal longitude { get; set; }
        public bool status { get; set; }

    }
}
