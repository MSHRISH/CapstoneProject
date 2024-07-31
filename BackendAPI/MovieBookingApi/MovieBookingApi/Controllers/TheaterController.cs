using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using MovieBookingApi.Models.DTOs.TheaterDTOs;

namespace MovieBookingApi.Controllers
{
    public class TheaterController : Controller
    {
        private readonly ITheaterServices _theaterServices;

        public TheaterController(ITheaterServices theaterServices) 
        {
            _theaterServices=theaterServices;
        }
        
        [HttpPost("AddTheater")]
        [ProducesResponseType(typeof(TheaterDetailsDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [Authorize(Policy = "RequireAdminRole")]
        public async Task<ActionResult<TheaterDetailsDTO>> AddTheater([FromBody] AddTheaterDTO addTheaterDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var res = await _theaterServices.AddTheater(addTheaterDTO);
                return CreatedAtAction(nameof(GetTheaterById), new { id = res.Id }, res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpGet("GetTheaterById")]
        [ProducesResponseType(typeof(TheaterDetailsDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TheaterDetailsDTO>> GetTheaterById(int theaterId)
        {
            try
            {
                var res = await _theaterServices.GetTheaterById(theaterId);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpGet("GetScreensByTheaterId")]
        [ProducesResponseType(typeof(List<ScreenDetailsDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<ScreenDetailsDTO>>> GetScreensByTheaterId(int theaterId)
        {
            try
            {
                var res = await _theaterServices.GetAllScreenDdetails(theaterId);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }


        }

        [HttpPost("AddScreen")]
        [ProducesResponseType(typeof(ScreenDetailsDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [Authorize(Policy = "RequireAdminRole")]
        public async Task<ActionResult<ScreenDetailsDTO>> AddScreen([FromBody] AddScreenDTO addScreenDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var res = await _theaterServices.AddScreen(addScreenDTO);
                return CreatedAtAction(nameof(GetScreenById), new { id = res.Id }, res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpGet("GetScreenById")]
        [ProducesResponseType(typeof(ScreenDetailsDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ScreenDetailsDTO>> GetScreenById(int screenId)
        {
            try
            {
                var res = await _theaterServices.GetScreenById(screenId);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpGet("GetAllTheaters")]
        [ProducesResponseType(typeof(List<AllTheatersMiniDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<AllTheatersMiniDTO>>> GetAllTheaters()
        {
            try
            {
                var res = await _theaterServices.GetAllTheatersList();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }


        }

        [HttpGet("GetAllSchemas")]
        [ProducesResponseType(typeof(List<AllSchemasMiniDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<AllSchemasMiniDTO>>> GetAllSchemas()
        {
            try
            {
                var res = await _theaterServices.GetAllTheSchemasList();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }


        }
    }
}
