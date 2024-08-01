namespace MovieBookingApi.Models.DTOs.MovieDTOs
{
    public class MovieDetailDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public FormatDetailDTO Format { get; set; }
        public LanguageDetailDTO Language { get; set; }
        public CertificationDetailDTO Certification { get; set; }

        public List<CastCrewDetailsDTO> CastCrewDetails { get; set; }
        public string PosterUrl { get; set; }
        public string LetterBoxUrl { get; set; }
        public DateTime RealeaseDate { get; set; }
        public int Duration { get; set; } // Duration in minutes
    }
}
