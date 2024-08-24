using API.CadastroBasico.Auxiliar.Dto;
using API.CadastroBasico.Auxiliar.Models;
using API.CadastroBasico.Auxiliar.RegraNegocio;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.CadastroBasico.Servicos
{
    public class PessoaServico
    {
        //Dependencias
        private CadastroBaseContext _context;
        private IMapper _mapper;
        private PessoaRegraNegocio _pessoaRegraNegocio;

        //Construtor
        public PessoaServico(CadastroBaseContext context, IMapper mapper, PessoaRegraNegocio pessoaRegraNegocio)
        {
            _context = context;
            _mapper = mapper;
            _pessoaRegraNegocio = pessoaRegraNegocio;
        }

        public bool Create([FromBody] PessoaCreateDto pessoaDto)
        {
            bool sucesso = true;

            _pessoaRegraNegocio.CPFValido(pessoaDto.Federal);
            _pessoaRegraNegocio.FormatarCPF(pessoaDto.Federal);
            // Verifica se o cpf existe no banco

            Pessoa pessoa = _mapper.Map<Pessoa>(pessoaDto);
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();

            return sucesso;
        }

        public IEnumerable<PessoaReadDto> Read()
        {
            return _mapper.Map<List<PessoaReadDto>>(_context.Pessoas.ToList());
        }

        public PessoaReadDto ReadPorId(int id)
        {
            PessoaReadDto pessoaDto = new PessoaReadDto();

            Pessoa pessoa = _context.Pessoas.FirstOrDefault(pessoa => pessoa.IdPessoa == id);
            if (pessoa != null)
            {
                pessoaDto = _mapper.Map<PessoaReadDto>(pessoa);

            }
            return pessoaDto;
        }


        public bool Update(int id, [FromBody] PessoaUpdateDto pessoaDto)
        {
            bool sucesso = false;
            Pessoa pessoa = _context.Pessoas.FirstOrDefault(pessoa => pessoa.IdPessoa == id);

            if (pessoa != null)
            {
                pessoa = _mapper.Map<Pessoa>(pessoaDto);
                _context.Pessoas.Update(pessoa);
                _context.SaveChanges();
                sucesso = true;
            }

            return sucesso;
        }


        public bool Deleta(int id)
        {
            bool sucesso = false;
            Pessoa pessoa = _context.Pessoas.FirstOrDefault(pessoa => pessoa.IdPessoa == id);

            if (pessoa != null)
            {
                _context.Remove(pessoa);
                _context.SaveChanges();
                sucesso = true;
            }

            return sucesso;
        }
    }
}
