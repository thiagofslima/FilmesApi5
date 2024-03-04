using AutoMapper;
using FilmesApi5.Data.Dtos.Cinema;
using FilmesApi5.Models;

namespace FilmesApi5.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>();
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
