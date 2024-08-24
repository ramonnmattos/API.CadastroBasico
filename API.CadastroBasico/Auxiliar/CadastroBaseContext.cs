using API.CadastroBasico.Auxiliar.Models;
using Microsoft.EntityFrameworkCore;

public class CadastroBaseContext : DbContext
{
    //contrutor
    public CadastroBaseContext(DbContextOptions<CadastroBaseContext> opts) : base(opts)
    {

    }
    public DbSet<Contato> Contatos { get; set; }   
    public DbSet<Pessoa> Pessoas { get; set; }
    

}
