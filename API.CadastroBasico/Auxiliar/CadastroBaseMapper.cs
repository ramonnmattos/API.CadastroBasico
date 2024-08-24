using API.CadastroBasico.Auxiliar.Dto;
using API.CadastroBasico.Auxiliar.Models;
using AutoMapper;

namespace API.CadastroBasico.Auxiliar
{
    public class CadastroBaseMapper : Profile
    {
        public CadastroBaseMapper()
        {

            CreateMap<PessoaCreateDto, Pessoa>();
            CreateMap<PessoaUpdateDto, Pessoa>();
            CreateMap<Pessoa, PessoaReadDto>();
            CreateMap<Pessoa, PessoaUpdateDto>();

            CreateMap<ContatoCreateDto, Contato>();
            CreateMap<ContatoUpdateDto, Contato>();
            CreateMap<Contato, ContatoReadDto>();
            CreateMap<Contato, ContatoUpdateDto>();

        }
    }
}
