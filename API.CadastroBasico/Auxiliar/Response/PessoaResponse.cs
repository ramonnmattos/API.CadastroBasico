namespace API.CadastroBasico.Auxiliar.Response

{
    public record PessoaResponse
        (
            int IdPessoa,
            string Nome,
            string? Federal,
            DateTime? DataNascimento
        );

}
