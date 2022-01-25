using CargoDeliverySystemAPI.Data;
using CargoDeliverySystemAPI.Models;
using CargoDeliverySystemAPI.Operations.UserOperations.Commands;
using CargoDeliverySystemAPI.Operations.UserOperations.Queries;
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
    public class UsersController : ControllerBase
    {

        private readonly CargoDeliveryDBContext _CargoDeliveryDBContext;

        public UsersController(CargoDeliveryDBContext CargoDeliveryDBContext)
        {
            _CargoDeliveryDBContext = CargoDeliveryDBContext;
        }

        [HttpPost("GetUserLoginControl")]
        public ActionResult<User> GetUserLoginControl([FromBody] GetUserLoginControlViewModel model)
        {
            GetUserLoginControlQuery getUserLogin = new GetUserLoginControlQuery(_CargoDeliveryDBContext);
            getUserLogin.Model = model;
            return Ok(getUserLogin.Handle());
        }

        [HttpGet("GetAllUser")]
        public ActionResult<List<User>> GetAllUser()
        {
            return _CargoDeliveryDBContext.Users.ToList();
        }


        [HttpPost("CreateUser")]
        public IActionResult CreateUser([FromBody] CreateUserCommandViewModel model)
        {
            CreateUserCommand createUser = new CreateUserCommand(_CargoDeliveryDBContext);
            createUser.Model = model;
            return Ok(createUser.Handle());
        }


        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser([FromBody] UpdateUserCommandViewModel model)
        {
            UpdateUserCommand updateUser = new UpdateUserCommand(_CargoDeliveryDBContext);
            updateUser.Model = model;
            return Ok(updateUser.Handle());
        }

    }
}
