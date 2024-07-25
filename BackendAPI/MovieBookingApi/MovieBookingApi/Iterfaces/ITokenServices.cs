namespace MovieBookingApi.Iterfaces
{
    public interface ITokenServices
    {
        public string GenerateToken(int UserId, string Role);
    }
}
