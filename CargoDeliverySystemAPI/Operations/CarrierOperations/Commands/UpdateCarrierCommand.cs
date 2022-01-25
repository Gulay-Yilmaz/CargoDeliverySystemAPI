using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.CarrierOperations.Commands
{
    public class UpdateCarrierCommand
    {
        private readonly ICargoDeliveryDBContext _cargoDeliveryDBContext;

        public UpdateCarrierCommandViewModel Model;

        public UpdateCarrierCommand(ICargoDeliveryDBContext cargoDeliveryDBContext)
        {
            _cargoDeliveryDBContext = cargoDeliveryDBContext;
        }


        public ResultModel<UpdateCarrierCommandViewModel> Handle()
        {
            try
            {
                Carrier carrier = _cargoDeliveryDBContext.Carrier.SingleOrDefault(p => p.Id == Model.Id);
                if (carrier != null)
                {
                    carrier.Latitude = Model.NewLatitude;
                    carrier.Longitude = Model.NewLongitude;
                    carrier.cargoName = Model.cargoName;
                    _cargoDeliveryDBContext.SaveChanges();

                    return ResultModel<UpdateCarrierCommandViewModel>.GenerateResult(Model, "Successfully updated to database(carrier)");
                }

                return ResultModel<UpdateCarrierCommandViewModel>.GenerateResult(Model, "no record!!!");
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
