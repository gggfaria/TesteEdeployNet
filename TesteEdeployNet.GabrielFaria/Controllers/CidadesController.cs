using System.Collections.Generic;
using System.Web.Mvc;
using TesteEdeployNet.GabrielFaria.EndPoints;
using TesteEdeployNet.GabrielFaria.ServiceAPI.Interfaces;
using TesteEdeployNet.GabrielFaria.ViewModel;

namespace TesteEdeployNet.GabrielFaria.Controllers
{
    public class CidadesController : Controller
    {

        ICidadeAPIService _cidadeAPIService;
        public CidadesController(ICidadeAPIService cidadeAPIService)
        {
            _cidadeAPIService = cidadeAPIService;
        }
        // GET: Cidades
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult BuscarCidades(SearchCidadeViewModel busca)
        {
            List<ViewCidadeViewModel> cidades = _cidadeAPIService.SelectSearch(busca, CidadesAPI.BUSCA_TODAS_CIDADES);
            return PartialView("_ListaCidades", cidades);
        }
    }
}