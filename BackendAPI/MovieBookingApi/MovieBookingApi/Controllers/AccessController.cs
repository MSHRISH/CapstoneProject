using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using MovieBookingApi.Models.DTOs.AccessDTOs;

namespace MovieBookingApi.Controllers
{
    public class AccessController : Controller
    {
        private readonly IAccessServices _accessServices;

        public AccessController(IAccessServices accessServices) 
        {
            _accessServices=accessServices;
        }

        [HttpPost("AdminLogin")]
        [ProducesResponseType(typeof(TokenDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<TokenDTO>> LoginAdmin([FromBody] LoginDTO loginDTO)
        {
            try
            {
                var res = await _accessServices.LoginAdmin(loginDTO);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(401, ex.Message));
            }
        }

        [HttpPost("UserLogin")]
        [ProducesResponseType(typeof(TokenDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<TokenDTO>> LoginUser([FromBody] LoginDTO loginDTO)
        {
            try
            {
                var res = await _accessServices.LoginUser(loginDTO);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(401, ex.Message));
            }
        }
    }
}
