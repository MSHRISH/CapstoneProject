using Microsoft.AspNetCore.Http.Features.Authentication;
using MovieBookingApi.Execptions;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using MovieBookingApi.Models.DTOs.AccessDTOs;
using MovieBookingApi.Repositories;
using System.Security.Cryptography;
using System.Text;

namespace MovieBookingApi.Services
{
    public class AccessServices:IAccessServices
    {
        private readonly IRepository<int, Admin> _adminRepository;
        private readonly IRepository<int, AdminAuth> _adminAuthRepository;
        private readonly ITokenServices _tokenServices;
        private readonly IRepository<int, User> _userRepository;
        private readonly IRepository<int, UserAuth> _userAuthRepository;

        public AccessServices(IRepository<int,Admin> adminRepository, IRepository<int,AdminAuth> adminAuthRepository, 
                                        ITokenServices tokenServices, IRepository<int,User> userRepository, 
                                        IRepository<int,UserAuth> userAuthRepository) 
        {
            _adminRepository=adminRepository;
            _adminAuthRepository=adminAuthRepository;
            _tokenServices=tokenServices;
            _userRepository=userRepository;
            _userAuthRepository=userAuthRepository;
        }

        public async Task<TokenDTO> LoginAdmin(LoginDTO loginDTO)
        {
            var admin = (await _adminRepository.GetAll()).FirstOrDefault(a => a.Email == loginDTO.Email);
            if (admin == null)
            {
                throw new InvalidCredentials();
            }
            AdminAuth adminAuth = (await _adminAuthRepository.GetAll()).FirstOrDefault(aa => aa.AdminId == admin.Id);

            HMACSHA512 hMACSHA = new HMACSHA512(adminAuth.PasswordHashKey);
            var PasswordHash = hMACSHA.ComputeHash(Encoding.UTF8.GetBytes(loginDTO.Password));
            bool isHashSame = ComparePassword(PasswordHash, adminAuth.PasswordHash);
            if(isHashSame)
            {
                return GenerateTokenDTO(admin.Id, "Admin");
            }
            throw new InvalidCredentials();
        }
        private TokenDTO GenerateTokenDTO(int UserId, string role)
        {
            TokenDTO tokenDTO = new TokenDTO();
            tokenDTO.UserId = UserId;
            tokenDTO.Token = _tokenServices.GenerateToken(UserId, role);
            tokenDTO.Role = role;
            return tokenDTO;
        }

        private bool ComparePassword(byte[] encrypterPass, byte[] password)
        {
            for (int i = 0; i < encrypterPass.Length; i++)
            {
                if (encrypterPass[i] != password[i])
                {
                    return false;
                }
            }
            return true;
        }

        public async Task<TokenDTO> LoginUser(LoginDTO loginDTO)
        {
            var user = (await _userRepository.GetAll()).FirstOrDefault(u => u.Email == loginDTO.Email);
            if (user== null)
            {
                throw new InvalidCredentials();
            }

            UserAuth userAuth = (await _userAuthRepository.GetAll()).FirstOrDefault(ua => ua.UserId== user.Id);
            HMACSHA512 hMACSHA = new HMACSHA512(userAuth.PasswordHashKey);
            var PasswordHash = hMACSHA.ComputeHash(Encoding.UTF8.GetBytes(loginDTO.Password));
            bool isHashSame = ComparePassword(PasswordHash, userAuth.PasswordHash);
            if (isHashSame)
            {
                return GenerateTokenDTO(user.Id, "User");
            }
            throw new InvalidCredentials();
        }
    }
}
