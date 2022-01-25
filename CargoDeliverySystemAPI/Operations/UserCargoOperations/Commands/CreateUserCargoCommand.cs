using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.UserCargoOperations.Commands
{
    public class CreateUserCargoCommand
    {
        private readonly ICargoDeliveryDBContext _cargoDeliveryDBContext;

        public CreateUserCargoCommandViewModel Model;

        public CreateUserCargoCommand(ICargoDeliveryDBContext cargoDeliveryDBContext)
        {
            _cargoDeliveryDBContext = cargoDeliveryDBContext;
        }


        public ResultModel<CreateUserCargoCommandViewModel> Handle()
        {
            try
            {
                UserCargo userCargo = new UserCargo()
                {
                    CargoId = Model.CargoId,
                    UserId = Model.UserId
                };

                _cargoDeliveryDBContext.UserCargos.Add(userCargo);
                _cargoDeliveryDBContext.SaveChanges();

                return ResultModel<CreateUserCargoCommandViewModel>.GenerateResult(Model, "Successfully written to database");
            }
            catch (Exception ex)
            {
                return ResultModel<CreateUserCargoCommandViewModel>.GenerateResult(Model, "Could not write to database. " + ex.Message);
            }
        }
    }
}
