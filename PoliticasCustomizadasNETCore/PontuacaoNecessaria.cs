using Microsoft.AspNetCore.Authorization;
//using PoliciesAuthApp1.Services.Requirements;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

public class PontuacaoNecessariaHandler : AuthorizationHandler<PontuacaoRequirement>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                   PontuacaoRequirement requirement)
    {
                
        /* Aqui você pode ir, por exemplo, buscar em um banco de dados a pontuação do usuário constante
         * no contexto.Para fins de demonstração, foi atribuído o valor 5100 manualmente */

        int pontuacao_usuario = 5100;

       
        if (pontuacao_usuario >= requirement.Pontuacao)
        {
            context.Succeed(requirement);
        }
        
       
        return Task.CompletedTask;
    }
}
