using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using MovieBookingApi.Models.DTOs.BookingDTOs;
using MovieBookingApi.Models.DTOs.MovieDTOs;
using System.Security.Claims;

namespace MovieBookingApi.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingServices _bookingServices;

        public BookingController(IBookingServices bookingServices) 
        {
            _bookingServices=bookingServices;
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
        [Authorize(Policy = "RequireAdminRole")]
        public async Task<ActionResult<BookingDetailsDTO>> DeleteBooking(int bookingId)
        {
            try
            {
                var res = await _bookingServices.DeleteBooking(bookingId);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(500, ex.Message));
            }
        }
    }
}
