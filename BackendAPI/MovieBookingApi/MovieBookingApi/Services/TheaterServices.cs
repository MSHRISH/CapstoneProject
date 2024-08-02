using MovieBookingApi.Execptions;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models;
using MovieBookingApi.Models.DTOs.TheaterDTOs;
using MovieBookingApi.Models.TheaterModels;
using MovieBookingApi.Repositories;

namespace MovieBookingApi.Services
{
    public class TheaterServices:ITheaterServices
    {
        private readonly IRepository<int, Theater> _theaterRepository;
        private readonly IRepository<int, Screen> _screenRepository;
        private readonly IRepository<int, Schema> _schemaRepository;
        private readonly IRepository<int, Show> _showRepository;
        private readonly IRepository<int, Snack> _snackRepository;

        public TheaterServices(IRepository<int,Theater> theaterRepository, IRepository<int,Screen> screenRepository,
                                IRepository<int,Schema> schemaRepository, IRepository<int,Show> showRepository
                                ,IRepository<int,Snack> snackRepository)
        {
            _theaterRepository=theaterRepository;
            _screenRepository=screenRepository;
            _schemaRepository = schemaRepository;
            _showRepository=showRepository;
            _snackRepository = snackRepository;
        }

      

        public async Task<TheaterDetailsDTO> AddTheater(AddTheaterDTO addTheaterDTO)
        {
            if(await CheckName(addTheaterDTO.Name))
            {
                throw new TheaterAlreadyExistsExecption();
            }
            var theater= new Theater { Name=addTheaterDTO.Name, Phone=addTheaterDTO.Phone, 
                            Address=addTheaterDTO.Address, District=addTheaterDTO.District};
            theater=await _theaterRepository.Add(theater);
            if(theater==null) 
            {
                throw new RegistrationFailedExecption();    
            }

            return await GetTheaterById(theater.Id);
        }
        public async Task<ScreenDetailsDTO> AddScreen(AddScreenDTO addScreenDTO)
        {
            var theater= await _theaterRepository.Get(addScreenDTO.TheaterId);
            if (theater == null)
            {
                throw new NoSuchTheaterFound();
            }
            if(await CheckScreenName(addScreenDTO.ScreenName, addScreenDTO.TheaterId))
            {
                throw new ScreenNameAlreadyExistsExecption();
            }
            var schema=await _schemaRepository.Get(addScreenDTO.SchemaId);
            if (schema == null)
            {
                throw new NoSuchSchemaFoundExecption();
            }
            var screen=new Screen { ScreenName=addScreenDTO.ScreenName, TheaterId=addScreenDTO.TheaterId, SchemaId=schema.Id};
            screen=await _screenRepository.Add(screen);
            if(screen==null)
            {
                throw new RegistrationFailedExecption();
            }
            return new ScreenDetailsDTO
            {
                ScreenName = screen.ScreenName,
                TheaterId = screen.TheaterId,
                SchemaId = screen.SchemaId,
                Id = screen.Id
            };
        }
        public async Task<ScreenDetailsDTO> GetScreenById(int screenId)
        {
            var screen=await _screenRepository.Get(screenId);
            if (screen == null)
            {
                throw new NoSuchScreenFoundExecption();
            }
            return new ScreenDetailsDTO
            {
                ScreenName = screen.ScreenName,
                TheaterId = screen.TheaterId,
                SchemaId = screen.SchemaId,
                Id = screen.Id
            };
        }


        private async Task<bool> CheckScreenName(string name, int theaterId)
        {
            var screens= await _screenRepository.GetAll();
            bool exists = screens.Any(s => s.TheaterId == theaterId && s.ScreenName == name);
            return exists;
        }
        public async Task<List<ScreenDetailsDTO>> GetAllScreenDdetails(int theaterID)
        {
            var theater= await _theaterRepository.Get(theaterID);
            if (theater == null)
            {
                throw new NoSuchTheaterFound();
            }
            var screens=await _screenRepository.GetAll();
            var screenDTOs = screens.Where(s => s.TheaterId == theaterID)
                        .Select(s => new ScreenDetailsDTO
                        {
                             Id=s.Id,
                             TheaterId=s.TheaterId,
                             ScreenName=s.ScreenName,
                             SchemaId=s.SchemaId,
                        }).ToList();
            return screenDTOs;
        }

        public async Task<TheaterDetailsDTO> GetTheaterById(int theaterId)
        {
            var theater=await _theaterRepository.Get(theaterId);
            if (theater == null)
            {
                throw new NoSuchTheaterFound();
            }
            return new TheaterDetailsDTO
            {
                Name = theater.Name,
                Phone = theater.Phone,
                Address = theater.Address,
                District = theater.District,
                Id = theater.Id,
                screenDetails= await GetAllScreenDdetails(theaterId),
            };
        }

        private async Task<bool> CheckName(string name)
        {
            var allTheaters=await _theaterRepository.GetAll();
            bool exists=allTheaters.Any(t => t.Name==name);
            return exists;
        }

        public async Task<List<AllTheatersMiniDTO>> GetAllTheatersList()
        {
            var theaters = await _theaterRepository.GetAll();
            var result = theaters.Select(t => new AllTheatersMiniDTO
            {
                TheaterId = t.Id,
                TheaterName = t.Name,
            }).ToList();
            return result;
        }

        public async Task<List<AllSchemasMiniDTO>> GetAllTheSchemasList()
        {
            var schemas=await _schemaRepository.GetAll();
            var result = schemas.Select(s => new AllSchemasMiniDTO
            {
                SchemaId = s.Id,
                SchemaName = s.Name,
            }).ToList();
            return result;
        }

        public async Task<List<TheaterSnackDetailsDTO>> GetSnackDetailsOfShow(int showid)
        {
            var show=await _showRepository.Get(showid);
            if (show == null)
            {
                throw new ShowNotFoundExecption();
            }
            var screen = await _screenRepository.Get(show.ScreenId);
            var theater = await _theaterRepository.Get(screen.TheaterId);

            var snacks = await _snackRepository.GetAll();
            var res = snacks.Where(s => s.TheaterId == theater.Id && s.IsAvailable==true).Select(s => new TheaterSnackDetailsDTO
                {
                     Id = s.Id,
                     IsAvailable = s.IsAvailable,
                     Price =s.Price,
                     SnackName=s.Name,
                }).ToList();
            return res;

        }
    }
}
