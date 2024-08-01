using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using MovieBookingApi.Models.DTOs.BookingDTOs;
using MovieBookingApi.Models.DTOs.MovieDTOs;
using MovieBookingApi.Models.DTOs.TheaterDTOs;
using System.Security.Claims;

namespace MovieBookingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : Controller
    {
        private readonly IBookingServices _bookingServices;

        public BookingController(IBookingServices bookingServices) 
        {
            _bookingServices=bookingServices;
        }
        [HttpGet("GetScreenLayout")]
        [ProducesResponseType(typeof(ScreenLayoutDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        //[Authorize(Policy = "RequireUserRole")]
        public async Task<ActionResult<ScreenLayoutDTO>> GetScreenLayout([FromQuery] int showId)
        {
            try
            {
                var res = await _bookingServices.GetScreenLayout(showId);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }

        }

        [HttpPost("Makebooking")]
        [ProducesResponseType(typeof(BookingDetailsDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [Authorize(Policy = "RequireUserRole")]
        public async Task<ActionResult<BookingDetailsDTO>> MakeBooking([FromBody] BookTicketsDTO bookTicketsDTO)
        {
            try
            {
                int.TryParse(User.FindFirst(ClaimTypes.Name)?.Value, out int parsedUserId);
                var res = await _bookingServices.BookTickets(bookTicketsDTO,parsedUserId);
                return CreatedAtAction(nameof(GetMyBookingById), new { id = res.BookingId }, res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpGet("GetMyBookingById")]
        [ProducesResponseType(typeof(BookingDetailsDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [Authorize(Policy = "RequireUserRole")]
        public async Task<ActionResult<BookingDetailsDTO>> GetMyBookingById(int bookingId)
        {
            try
            {
                int.TryParse(User.FindFirst(ClaimTypes.Name)?.Value, out int parsedUserId);
                var res = await _bookingServices.ViewBooking(bookingId, parsedUserId,false);
                return Ok(res);
            }
            catch (Exception ex) 
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpGet("GetAllMyBookings")]
        [ProducesResponseType(typeof(List<BookingDetailsDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [Authorize(Policy = "RequireUserRole")]
        public async Task<ActionResult<List<BookingDetailsDTO>>> GetAllMyBookings([FromQuery] int page = 1)
        {
            try
            {
                int.TryParse(User.FindFirst(ClaimTypes.Name)?.Value, out int parsedUserId);
                var res = await _bookingServices.GetAllBookings(page, parsedUserId, false);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }

        }

        [HttpGet("GetAllBookings")]
        [ProducesResponseType(typeof(List<BookingDetailsDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [Authorize(Policy = "RequireAdminRole")]
        public async Task<ActionResult<List<BookingDetailsDTO>>> GetAllBookings([FromQuery] int page = 1)
        {
            try
            {
                var res = await _bookingServices.GetAllBookings(page, 0, true);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }

        }

        [HttpPut("MakePayment")]
        [ProducesResponseType(typeof(BookingDetailsDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [Authorize(Policy = "RequireUserRole")]
        public async Task<ActionResult<BookingDetailsDTO>> MakePayment(int bookingId)
        {
            try
            {
                int.TryParse(User.FindFirst(ClaimTypes.Name)?.Value, out int parsedUserId);
                var res = await _bookingServices.PayForBooking(bookingId, parsedUserId);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpDelete("DeleteBooking")]
        [ProducesResponseType(typeof(BookingDetailsDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status500InternalServerError)]
        [Authorize(Policy = "RequireAdminUserRole")]
        public async Task<ActionResult<BookingDetailsDTO>> DeleteBooking(int bookingId)
        {
            try
            {
                var role = User.FindFirst(ClaimTypes.Role)?.Value;
                if(role == "Admin")
                {
                    var res = await _bookingServices.DeleteBooking(bookingId,0,true);
                    return Ok(res);
                }
                else
                {
                    int.TryParse(User.FindFirst(ClaimTypes.Name)?.Value, out int parsedUserId);

                    var res = await _bookingServices.DeleteBooking(bookingId, parsedUserId, false);

                    return Ok(res);
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(500, ex.Message));
            }
        }

        [HttpPost("AddShow")]
        [ProducesResponseType(typeof(ShowDetailsDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [Authorize(Policy = "RequireAdminRole")]
        public async Task<ActionResult<ShowDetailsDTO>> AddShow([FromBody] AddShowDTO addShowDTO)
        {
            try
            {
                
                var res = await _bookingServices.AddShow(addShowDTO);
                var locationUri = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}/{res.ID}");
                return Created(locationUri, res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpGet("GetDatesOfMovie")]
        [ProducesResponseType(typeof(List<DateTime>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<DateTime>>> GetRunningDatesOfMovie([FromQuery]  int movieId, [FromQuery]  string district)
        {
            try
            {
                var res = await _bookingServices.GetRunningDatesOfMovie(movieId, district);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpGet("GetMovieShowsByDateDistrict")]
        [ProducesResponseType(typeof(Dictionary<string, List<ShowDetailsDTO>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Dictionary<string, List<ShowDetailsDTO>>>> GetMovieShowsByDateDistrict([FromQuery] int movieId, 
                                                                                                        [FromQuery] string district, 
                                                                                                        [FromQuery] DateTime date)
        {
            try
            {
                var res = await _bookingServices.GetShowsByDateForMovie(movieId, date, district);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpGet("GetMoviesRunningInDistrict")]
        [ProducesResponseType(typeof(List<MovieDetailDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<MovieDetailDTO>>> GetMoviesRunningDistrict([FromQuery] string district)
        {
            try
            {
                var res = await _bookingServices.GetRunningMovies(district);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }
        }

        [HttpGet("GetAllScreens")]
        [ProducesResponseType(typeof(List<AllScreensMiniDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        //[Authorize(Policy = "RequireAdminRole")]
        public async Task<ActionResult<List<AllScreensMiniDTO>>> GetAllScreens()
        {
            try
            {
                var res = await _bookingServices.GetAllScreensList();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }

        }

        [HttpGet("GetAllMovies")]
        [ProducesResponseType(typeof(List<AllmoviesMiniDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        //[Authorize(Policy = "RequireAdminRole")]
        public async Task<ActionResult<List<AllmoviesMiniDTO>>> GetAllMovies()
        {
            try
            {
                var res = await _bookingServices.GetAllMoviesList();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(400, ex.Message));
            }

        }
    }
}
