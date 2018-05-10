using System.Web.Mvc;
using TesteEdeployNet.GabrielFaria.EndPoints;
using TesteEdeployNet.GabrielFaria.ServiceAPI.Interfaces;
using TesteEdeployNet.GabrielFaria.ViewModel;

namespace TesteEdeployNet.GabrielFaria.Controllers
{
    public class PontuacoesController : Controller
    {
        IPontuacaoAPIService _pontuacaoService;

        public PontuacoesController(IPontuacaoAPIService pontuacaoAPIService)
        {
            _pontuacaoService = pontuacaoAPIService;
        }

        [HttpPost]
        public ActionResult PontuacaoByCidadeEstado(SearchCidadeViewModel busca)
        {
            int pontos = _pontuacaoService.SelectByCidadeEstado(busca, PontosAPI.BUSCA_PONTOS);

            return Json(new { pontos });
        }
    }
}