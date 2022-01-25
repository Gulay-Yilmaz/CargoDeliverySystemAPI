using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.CarrierLogOperations.Commands
{
    public class CreateCarrierLogCommand
    {
        private readonly ICargoDeliveryDBContext _cargoDeliveryDBContext;

        public CreateCarrierLogCommandViewModel Model;

        public CreateCarrierLogCommand(ICargoDeliveryDBContext cargoDeliveryDBContext)
        {
            _cargoDeliveryDBContext = cargoDeliveryDBContext;
        }


        public ResultModel<CreateCarrierLogCommandViewModel> Handle()
        {
            try
            {
                CarrierLog carrierLog = new CarrierLog()
                {
                    CarrierId = Model.CarrierId,
                    Latitude = Model.Latitude,
                    Longitude = Model.Longitude,
                    Message = "success",
                    Date = DateTime.Now

                };

                _cargoDeliveryDBContext.CarriersLogs.Add(carrierLog);
                _cargoDeliveryDBContext.SaveChanges();

                return ResultModel<CreateCarrierLogCommandViewModel>.GenerateResult(Model, "Successfully written to database");
            }
            catch (Exception ex)
            {
                return ResultModel<CreateCarrierLogCommandViewModel>.GenerateResult(Model, "Could not write to database. " + ex.Message);
            }
        }

    }
}
