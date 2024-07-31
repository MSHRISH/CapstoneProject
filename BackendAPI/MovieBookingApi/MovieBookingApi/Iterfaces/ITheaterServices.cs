using MovieBookingApi.Models.DTOs.TheaterDTOs;

namespace MovieBookingApi.Iterfaces
{
    public interface ITheaterServices
    {
        public Task<TheaterDetailsDTO> AddTheater(AddTheaterDTO addTheaterDTO);
        public Task<TheaterDetailsDTO> GetTheaterById(int theaterId);

        public Task<ScreenDetailsDTO> AddScreen(AddScreenDTO addScreenDTO);
        public Task<ScreenDetailsDTO> GetScreenById(int screenId);
        public Task<List<ScreenDetailsDTO>> GetAllScreenDdetails(int theaterID);

        //Get All Theaters
        public Task<List<AllTheatersMiniDTO>> GetAllTheatersList();

        //Get All Schemas
        public Task<List<AllSchemasMiniDTO>> GetAllTheSchemasList();
    }
}
