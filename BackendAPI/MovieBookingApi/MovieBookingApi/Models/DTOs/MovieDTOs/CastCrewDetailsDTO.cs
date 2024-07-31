namespace MovieBookingApi.Models.DTOs.MovieDTOs
{
    public class CastCrewDetailsDTO
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }  
        public int MovieId { get; set; }
        public string Role { get; set; }
        public int MemberType { get; set; }
    }
}
