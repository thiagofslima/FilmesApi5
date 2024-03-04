using AutoMapper;
using FilmesApi5.Data.Dtos.Filme;
using FilmesApi5.Models;

namespace FilmesApi5.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
