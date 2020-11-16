using Models.Requests;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IRestClient
    {
        Task<TResponse> GetAsync<TRequest, TResponse>(string endpoint, TRequest request)
            where TRequest : class
            where TResponse : class;

        Task<string> PostAsync(string endpoint, AdvegoRequest body);
    }
}
