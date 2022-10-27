using Garage.Interfaces;
using Garage.Models;
using CarsParkDb.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Garage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ICreateUserService _createUserService;

        public UsersController(ICreateUserService createUserService)
        {
            _createUserService = createUserService;
        }

        [HttpPost]
        public async Task Add(CreateUserRequest request)
        {
           await _createUserService.Create(request);
        }
    }
}
