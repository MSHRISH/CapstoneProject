using MovieBookingApi.Models.DTOs.MovieDTOs;

namespace MovieBookingApi.Iterfaces
{
    public interface IMovieServices
    {
        public Task<MovieDetailDTO> AddMovie(AddMovieDTO addMovieDTO);
        public Task<MovieDetailDTO> GetMovieDetails(int movieId);

        public Task<ArtistDetailsDTO> AddArtist(AddArtistDTO addArtistDTO);

        public Task<ArtistDetailsDTO> GetArtistDetails(int artistId);

        public Task<CastCrewDetailsDTO> AddCastCrew(AddCastCrewDTO addCastCrewDTO);

        public Task<List<CastCrewDetailsDTO>> GetCastCrew(int movieId);
    }
}
