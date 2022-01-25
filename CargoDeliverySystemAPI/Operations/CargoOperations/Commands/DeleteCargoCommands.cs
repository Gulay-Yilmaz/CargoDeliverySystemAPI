using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.CargoOperations.Commands
{
    public class DeleteCargoCommands
    {
        private readonly ICargoDeliveryDBContext _cargoDeliveryDBContext;

        public DeleteCargoCommands(ICargoDeliveryDBContext cargoDeliveryDBContext)
        {
            _cargoDeliveryDBContext = cargoDeliveryDBContext;
        }

        public int CargoId;

        public ResultModel<Cargo> Handle()
        {
            try
            {
                Cargo cargo = _cargoDeliveryDBContext.Cargos.SingleOrDefault(p => p.Id == CargoId);
                _cargoDeliveryDBContext.Cargos.Remove(cargo);

                _cargoDeliveryDBContext.SaveChanges();

                return ResultModel<Cargo>.GenerateResult(cargo, "Successfully deleted to database");
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
