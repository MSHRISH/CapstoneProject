namespace MovieBookingApi.Models
{
    public class UserAuth
    {
        public int Id { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordHashKey { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
