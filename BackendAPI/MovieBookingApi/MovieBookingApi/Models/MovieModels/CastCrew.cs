﻿namespace MovieBookingApi.Models.MovieModels
{
    public class CastCrew
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public string Role { get; set; }
        public int MemberTypeId { get; set; }
        public MemberType MemberType { get; set; }
    }
}
