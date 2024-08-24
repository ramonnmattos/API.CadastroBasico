using System.ComponentModel.DataAnnotations;

namespace API.CadastroBasico.Auxiliar.Models;

public class Contato
{
    [Key]
    [Required]
    public int IdContato { get; set; }
    public string Celular { get; set; }

    public string TelefoneFixo { get; set; }

    public string TelefoneComercial { get; set; }

    //FK
    [Required]
    public int IdPessoa { get; set; }
    public virtual Pessoa Pessoas { get; set; }

}
