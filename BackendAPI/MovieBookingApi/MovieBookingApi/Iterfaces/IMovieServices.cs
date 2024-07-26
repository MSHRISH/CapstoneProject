using MovieBookingApi.Models.DTOs.MovieDTOs;

namespace MovieBookingApi.Iterfaces
{
    public interface IMovieServices
    {
        public Task<MovieDetailDTO> AddMovie(AddMovieDTO addMovieDTO);
        public Task<MovieDetailDTO> GetMovieDetails(int movieId);
    }
}
