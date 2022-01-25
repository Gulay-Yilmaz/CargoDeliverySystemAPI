using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Models
{
    public class CarrierLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CarrierId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
