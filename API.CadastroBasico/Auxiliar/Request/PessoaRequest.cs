namespace API.CadastroBasico.Auxiliar.Request
{
    public record PessoaResponse
        (
            string Nome,
            string? Federal,
            DateTime? DataNascimento
        );
}