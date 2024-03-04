using AutoMapper;
using FilmesApi5.Data.Dtos.Endereco;
using FilmesApi5.Models;

namespace FilmesApi5.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
