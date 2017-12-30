using Microsoft.AspNetCore.Authorization;

public class PontuacaoRequirement : IAuthorizationRequirement
{
    public int Pontuacao { get; private set; }

    public PontuacaoRequirement(int pontuacao)
    {
        Pontuacao = pontuacao;
    }
}
