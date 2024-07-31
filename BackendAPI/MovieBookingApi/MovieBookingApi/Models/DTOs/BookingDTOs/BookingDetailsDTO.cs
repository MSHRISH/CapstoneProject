namespace MovieBookingApi.Models.DTOs.BookingDTOs
{
    public class BookingDetailsDTO
    {
        public int BookingId { get; set; }
        public int BookedBy { get; set; }
        public float TicketAmount { get; set; }
        public float SnackAmount { get; set; }
        public float BillAmount { get; set; }
        public float Discount { get; set; }
        public float TotalAmount { get; set; }
        public bool PaymentStatus { get; set; }
        public DateTime BookedOn { get; set; }

        public string MovieName { get; set; }
        public string TheaterName { get; set; }
        public string ScreenName { get; set; }

        public List<string> BookedSeats { get; set; }
        public List<SnackDetailDTO> Snacks { get; set; }
        
    }
}
