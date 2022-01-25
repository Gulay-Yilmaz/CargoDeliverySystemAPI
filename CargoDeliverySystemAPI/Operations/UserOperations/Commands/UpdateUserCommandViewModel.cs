using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.UserOperations.Commands
{
    public class UpdateUserCommandViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
    }
}
