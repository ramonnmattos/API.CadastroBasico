using API.CadastroBasico.Auxiliar.Dto;
using API.CadastroBasico.Auxiliar.Models;
using API.CadastroBasico.Auxiliar.RegraNegocio;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.CadastroBasico.Servicos
{
    public class ContatoServico
    {
        //Dependencias
        private CadastroBaseContext _context;
        private IMapper _mapper;
        private ContatoRegraNegocio _contatoRegraNegocio;

        //Construtor
        public ContatoServico(CadastroBaseContext context, IMapper mapper, ContatoRegraNegocio ContatoRegraNegocio)
        {
            _context = context;
            _mapper = mapper;
            _contatoRegraNegocio = ContatoRegraNegocio;
        }

        public bool Create([FromBody] ContatoCreateDto ContatoDto)
        {
            bool sucesso = true;

            Contato Contato = _mapper.Map<Contato>(ContatoDto);
            _context.Contatos.Add(Contato);
            _context.SaveChanges();

            return sucesso;
        }

        public IEnumerable<ContatoReadDto> Read()
        {
            return _mapper.Map<List<ContatoReadDto>>(_context.Contatos.ToList());
        }

        public ContatoReadDto ReadPorId(int id)
        {
            ContatoReadDto ContatoDto = new ContatoReadDto();

            Contato Contato = _context.Contatos.FirstOrDefault(Contato => Contato.IdContato == id);
            if (Contato != null)
            {
                ContatoDto = _mapper.Map<ContatoReadDto>(Contato);

            }
            return ContatoDto;
        }


        public bool Update(int id, [FromBody] ContatoUpdateDto ContatoDto)
        {
            bool sucesso = false;
            Contato Contato = _context.Contatos.FirstOrDefault(Contato => Contato.IdContato == id);

            if (Contato != null)
            {
                Contato = _mapper.Map<Contato>(ContatoDto);
                _context.Contatos.Update(Contato);
                _context.SaveChanges();
                sucesso = true;
            }

            return sucesso;
        }


        public bool Deleta(int id)
        {
            bool sucesso = false;
            Contato Contato = _context.Contatos.FirstOrDefault(Contato => Contato.IdContato == id);

            if (Contato != null)
            {
                _context.Remove(Contato);
                _context.SaveChanges();
                sucesso = true;
            }

            return sucesso;
        }
    }
}
