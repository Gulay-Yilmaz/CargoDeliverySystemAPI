using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.UserCargoOperations.Commands
{
    public class CreateUserCargoCommandViewModel
    {
        public int UserId { get; set; }
        public int CargoId { get; set; }
    }
}
