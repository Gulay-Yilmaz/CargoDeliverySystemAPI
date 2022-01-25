using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Models;
using CargoDeliverySystemAPI.Operations.CarrierLogOperations.Commands;
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
    public class CarriersLogController : ControllerBase
    {
        private readonly CargoDeliveryDBContext _CargoDeliveryDBContext;

        public CarriersLogController(CargoDeliveryDBContext CargoDeliveryDBContext)
        {
            _CargoDeliveryDBContext = CargoDeliveryDBContext;
        }

        [HttpPost("CreateCarriersLog")]
        public IActionResult CreateCarriersLog([FromBody] CreateCarrierLogCommandViewModel model)
        {
            CreateCarrierLogCommand createCarriersLog = new CreateCarrierLogCommand(_CargoDeliveryDBContext);
            createCarriersLog.Model = model;
            return Ok(createCarriersLog.Handle());
        }


    }
}
