using TesteEdeployNet.GabrielFaria.ServiceAPI.Interfaces._Base;
using TesteEdeployNet.GabrielFaria.ViewModel;

namespace TesteEdeployNet.GabrielFaria.ServiceAPI.Interfaces
{
    public interface IPontuacaoAPIService : ICrudAPIService
    {
         int SelectByCidadeEstado(SearchCidadeViewModel busca, string url);

    }
}
