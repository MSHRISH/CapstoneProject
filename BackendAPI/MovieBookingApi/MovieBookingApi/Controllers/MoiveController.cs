using Microsoft.AspNetCore.Mvc;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using MovieBookingApi.Models.DTOs.AccessDTOs;
using MovieBookingApi.Models.DTOs.MovieDTOs;

namespace MovieBookingApi.Controllers
{
    public class MoiveController : Controller
    {
        private readonly IMovieServices _movieServices;

        public MoiveController(IMovieServices movieServices) 
        {
            _movieServices = movieServices;
        }

        [HttpPost("AddMovie")]
        [ProducesResponseType(typeof(MovieDetailDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MovieDetailDTO>> AddMovie([FromBody] AddMovieDTO addMovieDTO)
        {
            try
            {
                var res = await _movieServices.AddMovie(addMovieDTO);
                return CreatedAtAction(nameof(GetMovieById),new {id=res.Id},res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpGet("GetMovieById")]
        [ProducesResponseType(typeof(MovieDetailDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MovieDetailDTO>> GetMovieById(int movieId)
        {
            try
            {
                var res = await _movieServices.GetMovieDetails(movieId);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }
    }
}
