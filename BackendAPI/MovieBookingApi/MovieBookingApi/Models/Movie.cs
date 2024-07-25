namespace MovieBookingApi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int FormatId { get; set; }
        public Format Format { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int CertificateId { get; set; }
        public Certification Certification { get; set; }
        public string PosterUrl { get; set; }
        public string LetterBoxUrl { get; set; }
        public DateTime RealeaseDate { get; set; }
        public int Duration { get; set; } // Duration in minutes

        public ICollection<CastCrew> CastCrews { get; set; }
        public ICollection<Show> Shows { get; set; }

    }
}
