using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vie_Cap.Server.Tools;
using Vie_Cap.Shared;

namespace Vie_Cap.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRrpository _authRrpo;
        public AuthController(IAuthRrpository authRrpo)
        {
            _authRrpo = authRrpo;

        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegister request)
        {
            var response = await _authRrpo.Register(
            new User
            {
                DateOfBrith = request.DateOfBrith,
                Email = request.Email,
                LastName = request.LastName,
                FirstName = request.FristName,
                National_ID = request.National_ID,
                DateCreated = request.DateCreated,
                IsConfirmed = request.IsConfirmed

            }, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);


        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel request)
        {
            var response = await _authRrpo.Login(request.Email, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);


        }


    }
}
