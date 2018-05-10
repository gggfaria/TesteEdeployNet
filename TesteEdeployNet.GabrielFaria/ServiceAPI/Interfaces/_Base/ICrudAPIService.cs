using RestSharp;
using System.Collections.Generic;

namespace TesteEdeployNet.GabrielFaria.ServiceAPI.Interfaces._Base
{
    public interface ICrudAPIService
    {
        TEntity SelectById<TEntity>(int id, string url);
        List<TEntity> SelectAll<TEntity>(string url);
    }
}