namespace MovieBookingApi.Models
{
    public class AdminAuth
    {
        public int Id { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordHashKey { get; set; }

        public int AdminId { get; set; }
        public Admin Admin { get; set; }
    }
}
