using System.ComponentModel.DataAnnotations;

namespace API.CadastroBasico.Auxiliar.Dto;

public class PessoaCreateDto
{
    [Required(ErrorMessage = "O campo Nome é obrigatório!")]

    [StringLength(50)]
    public string? Nome { get; set; }
    [StringLength(50)]
    public string Federal { get; set; }

    public DateTime? DataNascimento { get; set; }

}

public class PessoaUpdateDto
{
    public string Nome { get; set; }

    public string? Federal { get; set; }

    public DateTime? DataNascimento { get; set; }
}

public class PessoaReadDto
{

    public int IdPessoa { get; set; }

    public string Nome { get; set; }

    public string? Federal { get; set; }

    public DateTime? DataNascimento { get; set; }

}