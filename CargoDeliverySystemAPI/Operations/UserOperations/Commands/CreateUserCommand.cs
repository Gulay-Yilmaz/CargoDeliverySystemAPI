using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.UserOperations.Commands
{
    public class CreateUserCommand
    {
        private readonly ICargoDeliveryDBContext _cargoDeliveryDBContext;

        public CreateUserCommandViewModel Model;

        public CreateUserCommand(ICargoDeliveryDBContext cargoDeliveryDBContext)
        {
            _cargoDeliveryDBContext = cargoDeliveryDBContext;
        }

        public ResultModel<CreateUserCommandViewModel> Handle()
        {
            try
            {
                User user = new User()
                {
                    CustomerName = Model.Username,
                    Password = Model.Password
                };

                _cargoDeliveryDBContext.Users.Add(user);
                _cargoDeliveryDBContext.SaveChanges();

                return ResultModel<CreateUserCommandViewModel>.GenerateResult(Model, "Successfully written to database");
            }
            catch (Exception ex)
            {
                return ResultModel<CreateUserCommandViewModel>.GenerateResult(Model, "Could not write to database. " + ex.Message);
            }
        }

    }
}
