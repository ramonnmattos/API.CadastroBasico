using API.CadastroBasico.Auxiliar.Dto;
using API.CadastroBasico.Servicos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.CadastroBasico.Controllers;

[ApiController]
[Route("[controller]")]
public class ContatoController : ControllerBase
{
    //Dependencias
    private ContatoServico _ContatoServico;

    //Construtor
    public ContatoController(CadastroBaseContext context, IMapper mapper, ContatoServico ContatoServico)
    {
        _ContatoServico = ContatoServico;
    }

    //Metodos (CRUD)
    [HttpPost]
    public bool Create([FromBody] ContatoCreateDto ContatoDto)
    {
        return _ContatoServico.Create(ContatoDto);
    }

    [HttpPut("{id}")]
    public bool Update(int id, [FromBody] ContatoUpdateDto ContatoDto)
    {
        return _ContatoServico.Update(id, ContatoDto);
    }


    [HttpDelete("{id}")]
    public bool Deleta(int id)
    {

        return _ContatoServico.Deleta(id);
    }

    [HttpGet]
    public IEnumerable<ContatoReadDto> Read()
    {
        return _ContatoServico.Read();
    }

    [HttpGet("{id}")]
    public ContatoReadDto ReadPorId(int id)
    {
        return _ContatoServico.ReadPorId(id);
    }



}
