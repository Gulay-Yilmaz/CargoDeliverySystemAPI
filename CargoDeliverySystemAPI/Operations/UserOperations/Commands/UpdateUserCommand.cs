using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.UserOperations.Commands
{
    public class UpdateUserCommand
    {
        private readonly ICargoDeliveryDBContext _cargoDeliveryDBContext;

        public UpdateUserCommandViewModel Model;

        public UpdateUserCommand(ICargoDeliveryDBContext cargoDeliveryDBContext)
        {
            _cargoDeliveryDBContext = cargoDeliveryDBContext;
        }

        public ResultModel<UpdateUserCommandViewModel> Handle()
        {
            try
            {
               User user = _cargoDeliveryDBContext.Users.FirstOrDefault(p => p.CustomerName == Model.Username && p.Password == Model.Password);
               if(user != null)
                {
                    user.Password = Model.NewPassword;
                    _cargoDeliveryDBContext.SaveChanges();

                    return ResultModel<UpdateUserCommandViewModel>.GenerateResult(Model, "Success");
                }

                return ResultModel<UpdateUserCommandViewModel>.GenerateResult(Model, "No record!");
            }
            catch (Exception ex)
            {
                return ResultModel<UpdateUserCommandViewModel>.GenerateResult(Model, "Could not write to database. " + ex.Message);
            }
        }
    }
}
