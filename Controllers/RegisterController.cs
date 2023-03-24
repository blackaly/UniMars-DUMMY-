﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniMars.Models;
using UniMars.Services.Interfaces;

namespace UniMars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IAuthService _authService;

        public RegisterController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterationModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!model.Password.Equals(model.ConfirmPassword)) return BadRequest("Password not matched");

            var res = await _authService.Register(model);

            if (!res.IsAuthenticated) { return BadRequest(res.Message); }

            return Ok(res);
        }

        [HttpPost("Login")]
        [AllowAnonymous]

        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var res = await _authService.Login(model);

            if (!res.IsAuthenticated) return BadRequest(res.Message);

            return Ok(res);
        }
    }
}
