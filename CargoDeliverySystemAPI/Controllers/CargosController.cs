using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Models;
using CargoDeliverySystemAPI.Operations.CargoOperations.Commands;
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
    public class CargosController : ControllerBase
    {
        private readonly CargoDeliveryDBContext _CargoDeliveryDBContext;

        public CargosController(CargoDeliveryDBContext CargoDeliveryDBContext)
        {
            _CargoDeliveryDBContext = CargoDeliveryDBContext;
        }

        [HttpPost("CreateCargo")]
        public IActionResult CreateCargp([FromBody] CreateCargoViewModel model)
        {
            CreateCargoCommand createCargo = new CreateCargoCommand(_CargoDeliveryDBContext);
            createCargo.Model = model;
            return Ok(createCargo.Handle());
        }

        [HttpGet("GetAllCargo")]
        public ActionResult<List<Cargo>> GetAllCargo()
        {
            return _CargoDeliveryDBContext.Cargos.ToList();
        }

        [HttpDelete("DeleteCargo")]
        public ActionResult<ResultModel<Cargo>> DeleteCargo(int id)
        {
            DeleteCargoCommands commands = new DeleteCargoCommands(_CargoDeliveryDBContext);
            commands.CargoId = id;
            return Ok(commands.Handle());
        }

        [HttpPut("UpdateCargo")]
        public ActionResult<ResultModel<Cargo>> UpdateCargo(string cargoName,bool status)
        {
            UpdateCargoCommand commands = new UpdateCargoCommand(_CargoDeliveryDBContext);
            commands.cargoName = cargoName;
            commands.status = status;
            return Ok(commands.Handle());
        }


    }
}
