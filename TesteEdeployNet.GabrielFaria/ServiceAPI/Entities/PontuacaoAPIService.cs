using Newtonsoft.Json;
using RestSharp;
using System;
using TesteEdeployNet.GabrielFaria.ServiceAPI.Entities._Base;
using TesteEdeployNet.GabrielFaria.ServiceAPI.Interfaces;
using TesteEdeployNet.GabrielFaria.ViewModel;

namespace TesteEdeployNet.GabrielFaria.ServiceAPI.Entities
{
    public class PontuacaoAPIService : CrudAPIService, IPontuacaoAPIService
    {
        public int SelectByCidadeEstado(SearchCidadeViewModel busca, string url)
        {
            _client = new RestClient(_urlBase);
            _request = new RestRequest(url, Method.POST);
            _request.RequestFormat = DataFormat.Json;
            _request.AddJsonBody(new {Nome = busca.Cidade , busca.Estado });
            var retorno = _client.Execute(_request);
            return JsonConvert.DeserializeObject<int>(retorno.Content);
        }
    }
}