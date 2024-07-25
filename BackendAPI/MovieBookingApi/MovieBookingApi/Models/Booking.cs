using System.Net.Sockets;

namespace MovieBookingApi.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int ShowId { get; set; }
        public Show Show { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public float BillAmount { get; set; }
        public float Discount { get; set; }
        public float TotalAmount { get; set; }
        public bool PaymentStatus { get; set; }
        public DateTime BookedOn { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<SnackOrder> SnackOrders { get; set; }
    }
}
