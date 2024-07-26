namespace MovieBookingApi.Models.DTOs.MovieDTOs
{
    public class AddMovieDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int FormatId { get; set; }
        public int LanguageId { get; set; }
        public int CertificateId { get; set; }
        public string PosterUrl { get; set; }
        public string LetterBoxUrl { get; set; }
        public DateTime RealeaseDate { get; set; } 
        public int Duration { get; set; } // Duration in minutes
    }
}
