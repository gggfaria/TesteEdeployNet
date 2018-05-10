using System.Collections.Generic;
using TesteEdeployNet.GabrielFaria.ServiceAPI.Interfaces._Base;
using TesteEdeployNet.GabrielFaria.ViewModel;

namespace TesteEdeployNet.GabrielFaria.ServiceAPI.Interfaces
{
    public interface ICidadeAPIService : ICrudAPIService
    {
        List<ViewCidadeViewModel> SelectSearch(SearchCidadeViewModel filtro, string url);

    }
}