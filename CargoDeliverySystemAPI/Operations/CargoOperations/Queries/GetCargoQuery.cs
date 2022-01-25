using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.CargoOperations.Queries
{
    public class GetCargoQuery
    {
        private readonly ICargoDeliveryDBContext _cargoDeliveryDBContext; //veritabanı erişimi için oluşturdugum degisken

        public GetCargoViewModel Model; //istedigim alanları GetCargoViewModel'de belirtmistim. Şimdi onlara atama yapmak için nesnesini ürettim

        public GetCargoQuery(ICargoDeliveryDBContext cargoDeliveryDBContext)
        {
            _cargoDeliveryDBContext = cargoDeliveryDBContext;
        }

        public Cargo Handle() //donus tipi bir cargo olacak
        {
            return _cargoDeliveryDBContext.Cargos.SingleOrDefault(p => p.Latitude == Model.latitude && p.Longitude == Model.longitude && p.deliveryStatus == Model.status);
        }

    }
}
