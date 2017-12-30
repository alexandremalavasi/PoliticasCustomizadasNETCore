using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace PoliticasCustormizadasNETCore.Pages
{

    [Authorize(Policy = "PoliticaPontuacao")]
    public class CancelamentoModel : PageModel
    {
        public string Message { get; set; }

        
        public void OnGet()
        {
            Message = "Parabéns. Você atingiu a pontuação acima de 5000 pontos!";
        }
    }
}
