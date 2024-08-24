using API.CadastroBasico.Auxiliar.Dto;
using API.CadastroBasico.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace API.CadastroBasico.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{
    //Dependencias
    private PessoaServico _pessoaServico;

    //Construtor
    public PessoaController(PessoaServico pessoaServico)
    {
        _pessoaServico = pessoaServico;
    }

    //Metodos (CRUD)
    [HttpPost]
    public bool Create([FromBody] PessoaCreateDto pessoaDto)
    {
        return _pessoaServico.Create(pessoaDto);
    }

    [HttpPut("{id}")]
    public bool Update(int id, [FromBody] PessoaUpdateDto pessoaDto)
    {
        return _pessoaServico.Update(id, pessoaDto);
    }


    [HttpDelete("{id}")]
    public bool Deleta(int id)
    {
        return _pessoaServico.Deleta(id);
    }

    [HttpGet]
    public IEnumerable<PessoaReadDto> Read()
    {
        return _pessoaServico.Read();
    }

    [HttpGet("{id}")]
    public PessoaReadDto ReadPorId(int id)
    {
        return _pessoaServico.ReadPorId(id);
    }

}
