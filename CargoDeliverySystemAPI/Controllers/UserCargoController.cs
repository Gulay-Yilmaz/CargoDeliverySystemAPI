using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Operations.UserCargoOperations.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCargoController : ControllerBase
    {
        private readonly CargoDeliveryDBContext _CargoDeliveryDBContext;

        public UserCargoController(CargoDeliveryDBContext CargoDeliveryDBContext)
        {
            _CargoDeliveryDBContext = CargoDeliveryDBContext;
        }


        [HttpPost("CreateUserCargo")]
        public IActionResult CreateUserCargo([FromBody] CreateUserCargoCommandViewModel model)
        {
            CreateUserCargoCommand createUserCargo = new CreateUserCargoCommand(_CargoDeliveryDBContext);
            createUserCargo.Model = model;
            return Ok(createUserCargo.Handle());
        }
    }
}
