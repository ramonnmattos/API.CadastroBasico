using API.CadastroBasico.Auxiliar.Models;

namespace API.CadastroBasico.Auxiliar.Dto;

public class ContatoCreateDto
{
    public string Celular { get; set; }

    public string TelefoneFixo { get; set; }

    public string TelefoneComercial { get; set; }

}

public class ContatoUpdateDto
{
    public string Celular { get; set; }

    public string TelefoneFixo { get; set; }

    public string TelefoneComercial { get; set; }
}

public class ContatoReadDto
{
    public int IdContato { get; set; }
    public string Celular { get; set; }
    public string TelefoneFixo { get; set; }
    public string TelefoneComercial { get; set; }
    public int IdPessoa { get; set; }
    public virtual Pessoa Pessoa { get; set; }
}
