using AutoMapper;
using FilmesApi5.Data.Dtos;
using FilmesApi5.Models;

namespace FilmesApi5.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateSessaoDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
