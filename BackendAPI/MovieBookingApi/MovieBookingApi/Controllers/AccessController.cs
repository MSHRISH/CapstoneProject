using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using MovieBookingApi.Models.DTOs.AccessDTOs;
using System.Security.Claims;

namespace MovieBookingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
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

        [HttpPost("UserSignup")]
        [ProducesResponseType(typeof(UserDetailsDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UserDetailsDTO>> SignupUser([FromBody] RegisterUserDTO registerUserDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var res = await _accessServices.RegisterUser(registerUserDTO);
                var locationUri = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}/{res.UserId}");
                return Created(locationUri, res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }

        }


        [HttpPost("UserLogin")]
        [ProducesResponseType(typeof(TokenDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<TokenDTO>> LoginUser([FromBody] LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
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

        [HttpGet("GetMyProfile")]
        [ProducesResponseType(typeof(UserDetailsDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [Authorize(Policy = "RequireUserRole")]
        public async Task<ActionResult<UserDetailsDTO>> GetMyProfile()
        {
            try
            {
                int.TryParse(User.FindFirst(ClaimTypes.Name)?.Value, out int parsedUserId);
                var res = await _accessServices.GetUserDetail(parsedUserId);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpGet("GetUserById")]
        [ProducesResponseType(typeof(UserDetailsDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [Authorize(Policy = "RequireAdminRole")]
        public async Task<ActionResult<UserDetailsDTO>> GetUserById(int userId)
        {
            try
            {
                var res= await _accessServices.GetUserDetail(userId);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }


    }
}
