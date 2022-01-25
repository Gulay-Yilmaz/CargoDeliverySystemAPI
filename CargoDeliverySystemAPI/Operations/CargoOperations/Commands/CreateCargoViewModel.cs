using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.CargoOperations.Commands
{
    public class CreateCargoViewModel //eklerken içinde ne olacaksa buraya yazılır. Burada kargo eklerken ben lat,long aldıgım icin
                                      //burada sadece lat ve long alanlarını oluşturdum
    {
        public int UserId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string CargoName { get; set; }
    }
}
