using System.ComponentModel.DataAnnotations;

namespace API.CadastroBasico.Auxiliar.Models;

public class Pessoa
{

    [Key]
    [Required]
    public int IdPessoa { get; set; }

    [Required(ErrorMessage = "O campo Nome é obrigatório!")]
    [MaxLength(255)]
    public string Nome { get; set; }
    [MaxLength(50)]
    public string? Federal { get; set; }

    public DateTime? DataNascimento { get; set; }

}
