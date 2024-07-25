using MovieBookingApi.Models.DTOs;

namespace MovieBookingApi.Iterfaces
{
    public interface IAuthenticationServices
    {
        public Task<TokenDTO> LoginAdmin(LoginDTO loginDTO);
    }
}
