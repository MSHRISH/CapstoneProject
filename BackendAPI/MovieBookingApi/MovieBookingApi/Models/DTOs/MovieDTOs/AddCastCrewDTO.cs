namespace MovieBookingApi.Models.DTOs.MovieDTOs
{
    public class AddCastCrewDTO
    {
        public int ArtistId { get; set; }
        public int MovieId { get; set; }
        public string Role { get; set; }
        public int MemberType { get; set; }
    }
}
