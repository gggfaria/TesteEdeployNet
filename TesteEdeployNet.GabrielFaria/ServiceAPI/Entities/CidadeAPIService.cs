using System.Collections.Generic;
using System.Linq;
using TesteEdeployNet.GabrielFaria.ServiceAPI.Entities._Base;
using TesteEdeployNet.GabrielFaria.ServiceAPI.Interfaces;
using TesteEdeployNet.GabrielFaria.ViewModel;

namespace TesteEdeployNet.GabrielFaria.ServiceAPI.Entities
{
    public class CidadeAPIService : CrudAPIService, ICidadeAPIService
    {
        public List<ViewCidadeViewModel> SelectSearch(SearchCidadeViewModel filtro, string url)
        {
            List<ViewCidadeViewModel> cidades = base.SelectAll<ViewCidadeViewModel>(url);
            cidades = cidades.Where(c =>
                                    (string.IsNullOrEmpty(filtro.Estado) ? true : c.Estado.ToUpper().Contains(filtro.Estado.Trim().ToUpper())) &&
                                    (string.IsNullOrEmpty(filtro.Cidade) ? true : c.Nome.ToUpper().Contains(filtro.Cidade.Trim().ToUpper()))
                                    ).ToList();

            return cidades;
        }
    }
}