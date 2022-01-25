using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.UserOperations.Queries
{
    public class GetUserLoginControlQuery
    {
        private readonly ICargoDeliveryDBContext _cargoDeliveryDBContext;

        public GetUserLoginControlViewModel Model;

        public GetUserLoginControlQuery(ICargoDeliveryDBContext cargoDeliveryDBContext)
        {
            _cargoDeliveryDBContext = cargoDeliveryDBContext;
        }

        public User Handle()
        {
            return _cargoDeliveryDBContext.Users.SingleOrDefault(p => p.CustomerName == Model.Username && p.Password == Model.Password);
        }
    }
}
