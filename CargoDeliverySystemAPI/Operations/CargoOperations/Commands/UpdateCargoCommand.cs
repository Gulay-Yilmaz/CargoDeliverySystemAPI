using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.CargoOperations.Commands
{
    public class UpdateCargoCommand
    {
        private readonly ICargoDeliveryDBContext _cargoDeliveryDBContext;

        public UpdateCargoCommand(ICargoDeliveryDBContext cargoDeliveryDBContext)
        {
            _cargoDeliveryDBContext = cargoDeliveryDBContext;
        }

        public string cargoName;
        public bool status;
        public ResultModel<Cargo> Handle()
        {
            try
            {
                Cargo cargo = _cargoDeliveryDBContext.Cargos.SingleOrDefault(p => p.CargoName == cargoName);
                if (cargo != null)
                {
                    cargo.deliveryStatus = status;
                    _cargoDeliveryDBContext.SaveChanges();

                    return ResultModel<Cargo>.GenerateResult(cargo, "Successfully updated to database");
                }

                return ResultModel<Cargo>.GenerateResult(cargo, "no record!!!");
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
