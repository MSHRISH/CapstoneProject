using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using MovieBookingApi.Models.DTOs.AccessDTOs;
using MovieBookingApi.Models.DTOs.BookingDTOs;
using MovieBookingApi.Models.DTOs.MovieDTOs;
using MovieBookingApi.Services;

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
        [Authorize(Policy = "RequireAdminRole")]
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

        [HttpPost("AddArtist")]
        [ProducesResponseType(typeof(ArtistDetailsDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [Authorize(Policy = "RequireAdminRole")]
        public async Task<ActionResult<ArtistDetailsDTO>> AddArtist([FromBody] AddArtistDTO addArtistDTO)
        {
            try
            {
                var res = await _movieServices.AddArtist(addArtistDTO);
                return CreatedAtAction(nameof(GetArtistById), new { id = res.Id }, res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }


        [HttpGet("GetArtistById")]
        [ProducesResponseType(typeof(ArtistDetailsDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ArtistDetailsDTO>> GetArtistById(int artistId)
        {
            try
            {
                var res = await _movieServices.GetArtistDetails(artistId);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpPost("AddCastCrew")]
        [ProducesResponseType(typeof(CastCrewDetailsDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [Authorize(Policy = "RequireAdminRole")]
        public async Task<ActionResult<CastCrewDetailsDTO>> AddCastCrew([FromBody] AddCastCrewDTO addCastCrewDTO)
        {
            try
            {
                var res = await _movieServices.AddCastCrew(addCastCrewDTO);
                var locationUri = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}/{res.Id}");
                return Created(locationUri, res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpGet("GetCastCrew")]
        [ProducesResponseType(typeof(List<CastCrewDetailsDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        
        public async Task<ActionResult<List<CastCrewDetailsDTO>>> GetCastCrew([FromQuery] int movieId)
        {
            try
            {
                var res = await _movieServices.GetCastCrew(movieId);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }

        }
    }
}
