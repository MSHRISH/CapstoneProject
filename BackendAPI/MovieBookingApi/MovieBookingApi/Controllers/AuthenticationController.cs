﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using MovieBookingApi.Models.DTOs;

namespace MovieBookingApi.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationServices _authenticationServices;

        public AuthenticationController(IAuthenticationServices authenticationServices) 
        {
            _authenticationServices=authenticationServices;
        }

        [HttpPost("Login")]
        [ProducesResponseType(typeof(TokenDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<TokenDTO>> LoginAdmin([FromBody] LoginDTO loginDTO)
        {
            try
            {
                var res = await _authenticationServices.LoginAdmin(loginDTO);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(401, ex.Message));
            }
        }
    }
}
