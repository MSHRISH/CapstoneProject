using Microsoft.AspNetCore.Http.Features.Authentication;
using MovieBookingApi.Context;
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
        private readonly MovieBookingContext _dbContext;

        public AccessServices(IRepository<int,Admin> adminRepository, IRepository<int,AdminAuth> adminAuthRepository, 
                                        ITokenServices tokenServices, IRepository<int,User> userRepository, 
                                        IRepository<int,UserAuth> userAuthRepository, MovieBookingContext dbContext) 
        {
            _adminRepository=adminRepository;
            _adminAuthRepository=adminAuthRepository;
            _tokenServices=tokenServices;
            _userRepository=userRepository;
            _userAuthRepository=userAuthRepository;
            _dbContext=dbContext;
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

        public async Task<UserDetailsDTO> RegisterUser(RegisterUserDTO registerUserDTO)
        {
            //Check Email
            if(await CheckRegisterEmail(registerUserDTO.Email))
            {
                throw new EmailAlreadyExistExecption();
            }
            //Check Phone Number
            if(await CheckRegosterPhone(registerUserDTO.Phone))
            {
                throw new PhoneAlreadyExistExecption();
            }

            //Register
            using (var transaction = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var user = new User { Name = registerUserDTO.Name, Email = registerUserDTO.Email, Phone = registerUserDTO.Phone };
                    user = await _userRepository.Add(user);
                    if (user == null)
                    {
                        throw new RegistrationFailedExecption();
                    }
                    HMACSHA512 hMACSHA = new HMACSHA512();
                    var userAuth = new UserAuth { UserId = user.Id, PasswordHashKey = hMACSHA.Key,
                        PasswordHash = hMACSHA.ComputeHash(Encoding.UTF8.GetBytes(registerUserDTO.Password)) };
                    userAuth = await _userAuthRepository.Add(userAuth);

                    if(userAuth == null)
                    {
                        throw new RegistrationFailedExecption();
                    }

                    await _dbContext.SaveChangesAsync();
                    // Commit the transaction
                    await transaction.CommitAsync();
                    return await GetUserDetail(user.Id);
                }
                catch (Exception ex)
                {
                    // Roll back the transaction
                    await transaction.RollbackAsync();
                    throw new RegistrationFailedExecption();
                }
            }
        }

        private async Task<bool> CheckRegisterEmail(string email)
        {
            var allUsers=await _userRepository.GetAll();
            bool exists = allUsers.Any(u => u.Email == email);
            return exists;
        }
        private async Task<bool> CheckRegosterPhone(string Phone)
        {
            var allUsers=await _userRepository.GetAll();
            bool exists = allUsers.Any(u => u.Phone == Phone);
            return exists;
        }

        public async Task<UserDetailsDTO> GetUserDetail(int userid)
        {
            var user = await _userRepository.Get(userid);
            if(user == null)
            {
                throw new NoSuchUserFoundExecption();
            }
            return new UserDetailsDTO
            {
                UserId = userid,
                Name = user.Name,
                Email = user.Email,
                Phone = user.Phone,
            };
        }
    }
}
