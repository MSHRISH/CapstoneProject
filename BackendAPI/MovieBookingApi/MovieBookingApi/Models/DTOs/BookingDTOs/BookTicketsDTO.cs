namespace MovieBookingApi.Models.DTOs.BookingDTOs
{
    public class BookTicketsDTO
    {
        public int ShowId { get; set; }
        public bool AvailDiscount { get; set; }
        public bool AvailSnack { get; set; }
        public List<int> SeatsBooked { get; set; }

      
        public List<BookSnackDTO> Snacks { get; set; }
    }
}
