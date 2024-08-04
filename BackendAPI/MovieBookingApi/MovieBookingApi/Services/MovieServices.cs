using MovieBookingApi.Execptions;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Models.DTOs.MovieDTOs;
using MovieBookingApi.Models.MovieModels;
using MovieBookingApi.Repositories;

namespace MovieBookingApi.Services
{
    public class MovieServices:IMovieServices
    {
        private readonly IRepository<int, Movie> _movieRepository;
        private readonly IRepository<int, Artist> _artistRepository;
        private readonly IRepository<int, CastCrew> _castCrewRepository;
        private readonly IRepository<int, Certification> _certificationRepository;
        private readonly IRepository<int, Format> _formatRepository;
        private readonly IRepository<int, Language> _languageRepository;
        

        public MovieServices(IRepository<int,Movie> movieRepository, IRepository<int, Artist> artistRepository,
                            IRepository<int,CastCrew> castCrewRepository, IRepository<int,Certification> certificationRepository,
                            IRepository<int,Format> formatRepository,IRepository<int,Language> languageRepository) 
        {
            _movieRepository= movieRepository;
            _artistRepository= artistRepository;
            _castCrewRepository= castCrewRepository;
            _certificationRepository= certificationRepository;
            _formatRepository= formatRepository;
            _languageRepository= languageRepository;
        }

        public async Task<ArtistDetailsDTO> AddArtist(AddArtistDTO addArtistDTO)
        {
            if(await CheckArtistName(addArtistDTO.Name))
            {
                throw new ArtistAlreadyExistsExecption();
            }
            var artist=new Artist {  Name= addArtistDTO.Name, About=addArtistDTO.About };
            artist=await _artistRepository.Add(artist);

            return new ArtistDetailsDTO { Id = artist.Id, Name = artist.Name, About = artist.About };
        }
        public async Task<ArtistDetailsDTO> GetArtistDetails(int artistId)
        {
            var artist=await _artistRepository.Get(artistId);
            if (artist == null)
            {
                throw new NoSuchArtistFoundExecption();
            }
            return new ArtistDetailsDTO { Id=artist.Id, Name= artist.Name, About=artist.About };
        }
        private async Task<bool> CheckArtistName( string artistName)
        {
            var artists=await _artistRepository.GetAll();
            bool exists=artists.Any(a => a.Name== artistName);
            return exists;
        }

        public async Task<MovieDetailDTO> AddMovie(AddMovieDTO addMovieDTO)
        {
            var movie=await GenerateMovieModel(addMovieDTO);
            try
            { 
                movie=await _movieRepository.Add(movie);
                if (movie == null)
                {
                    throw new MovieNotAddedExecption();
                }
                return await GetMovieDetails(movie.Id);
            }
            catch (Exception ex)
            {
                throw new MovieNotAddedExecption();
            }
        }

        public async Task<Movie> GenerateMovieModel(AddMovieDTO addMovieDTO)
        {
            var format = await _formatRepository.Get(addMovieDTO.FormatId);
            if (format == null)
            {
                throw new FormatNotFoundExecption();
            }
            var language=await _languageRepository.Get(addMovieDTO.LanguageId);
            if(language == null)
            {
                throw new LanguageNotFoundExecption();
            }
            var certification=await _certificationRepository.Get(addMovieDTO.CertificateId);
            if(certification == null)
            {
                throw new CertificationNotFoundExecption();
            }
            return new Movie
            {
                Title = addMovieDTO.Title,
                Description = addMovieDTO.Description,
                FormatId = addMovieDTO.FormatId,
                LanguageId = addMovieDTO.LanguageId,
                CertificateId = addMovieDTO.CertificateId,
                PosterUrl = addMovieDTO.PosterUrl,
                LetterBoxUrl = addMovieDTO.LetterBoxUrl,
                RealeaseDate = addMovieDTO.RealeaseDate,
                Duration = addMovieDTO.Duration,
            };
        }
        public async Task<MovieDetailDTO> GetMovieDetails(int movieId)
        {
            var movie=await _movieRepository.Get(movieId);
            if(movie == null)
            {
                throw new MovieNotFoundExecption();
            }
            try
            {
                var format = await _formatRepository.Get(movie.FormatId);
                var language = await _languageRepository.Get(movie.LanguageId);
                var certification = await _certificationRepository.Get(movie.CertificateId);
                var castCrews=await _castCrewRepository.GetAll();
                var artists=await _artistRepository.GetAll();
                var castCrewList = (from castcrew in castCrews
                                    join artist in artists on castcrew.ArtistId equals artist.Id
                                    where castcrew.MovieId==movieId
                                    select new CastCrewDetailsDTO
                                    {
                                        ArtistName=artist.Name,
                                        Role=castcrew.Role
                                    }).ToList();
                return new MovieDetailDTO
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Description = movie.Description,
                    Format = new FormatDetailDTO { Id = format.Id, FormatName = format.FormatName},
                    Language=new LanguageDetailDTO { LanguageId=language.Id, LanguageName=language.LanguageName},
                    Certification=new CertificationDetailDTO { CertificationId=certification.Id, CertificateType=certification.CertificateType},
                    CastCrewDetails=castCrewList,
                    PosterUrl = movie.PosterUrl,
                    LetterBoxUrl = movie.LetterBoxUrl,
                    RealeaseDate = movie.RealeaseDate,
                    Duration = movie.Duration
                };
            }
            catch(Exception ex)
            {
                throw new MovieNotFoundExecption();
            }
            
        }

        public async Task<CastCrewDetailsDTO> AddCastCrew(AddCastCrewDTO addCastCrewDTO)
        {
            var artist=await _artistRepository.Get(addCastCrewDTO.ArtistId);
            if(artist==null)
            {
                throw new NoSuchArtistFoundExecption();
            }
            var movie=await _movieRepository.Get(addCastCrewDTO.MovieId);
            if(movie == null)
            {
                throw new MovieNotFoundExecption();
            }
           
            var castCrew=new CastCrew { ArtistId=artist.Id,  MovieId=movie.Id, Role=addCastCrewDTO.Role };
            castCrew=await _castCrewRepository.Add(castCrew);
            if (castCrew == null)
            {
                throw new RegistrationFailedExecption();
            }

            return new CastCrewDetailsDTO
            {
                ArtistId = artist.Id,
                ArtistName=artist.Name,
                MovieId = movie.Id,
         
                Role = addCastCrewDTO.Role,
                Id = castCrew.Id,
            };
        }

        public async Task<List<CastCrewDetailsDTO>> GetCastCrew(int movieId)
        {
            var movie = await _movieRepository.Get(movieId);
            if (movie == null)
            {
                throw new MovieNotFoundExecption();
            }
            var castCrew = await _castCrewRepository.GetAll();
            var artists=await _artistRepository.GetAll();

            var castCrewDTO = from castcrew in castCrew
                              join artist in artists on castcrew.ArtistId equals artist.Id
                              where castcrew.MovieId == movieId
                              select new CastCrewDetailsDTO
                              {
                                  Id = castcrew.Id,
                                  ArtistId = castcrew.ArtistId,
                                  ArtistName = artist.Name,
                                  MovieId = movie.Id,
                                  Role = castcrew.Role,
                                 
                              };
            return castCrewDTO.ToList();
        }
    }
}
