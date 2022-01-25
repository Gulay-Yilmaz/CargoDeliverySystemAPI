using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Models;
using CargoDeliverySystemAPI.Operations.CarrierOperations.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CargoDeliverySystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrierController : ControllerBase
    {
        private readonly CargoDeliveryDBContext _CargoDeliveryDBContext;
        public CarrierController(CargoDeliveryDBContext CargoDeliveryDBContext)
        {
            _CargoDeliveryDBContext = CargoDeliveryDBContext;
        }

        [HttpPut("UpdateCarrier")]
        public IActionResult UpdateUser([FromBody] UpdateCarrierCommandViewModel model)
        {
            UpdateCarrierCommand updateCarrier = new UpdateCarrierCommand(_CargoDeliveryDBContext);
            updateCarrier.Model = model;
            return Ok(updateCarrier.Handle());
        }


        [HttpGet("GetAllCarrier")]
        public ActionResult<List<Carrier>> GetAllCarrier()
        {
            return _CargoDeliveryDBContext.Carrier.ToList();
        }

    }
}
