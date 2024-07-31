using MovieBookingApi.Models.DTOs.AccessDTOs;

namespace MovieBookingApi.Iterfaces
{
    public interface IAccessServices
    {
        public Task<TokenDTO> LoginAdmin(LoginDTO loginDTO);
        public Task<TokenDTO> LoginUser(LoginDTO loginDTO);
        public Task<UserDetailsDTO> RegisterUser(RegisterUserDTO registerUserDTO);

        public Task<UserDetailsDTO> GetUserDetail(int userid);
    }
}
