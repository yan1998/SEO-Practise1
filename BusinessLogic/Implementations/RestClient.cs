using BusinessLogic.Abstractions;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class RestClient : IRestClient
    {
        private readonly HttpClient _httpClient;
        public RestClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<TResponse> GetAsync<TRequest, TResponse>(string endpoint, TRequest request)
            where TRequest: class
            where TResponse: class
        {
            var queryParameters = GenerateQueryParameters(request);
            var response = await _httpClient.GetAsync(endpoint + queryParameters);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<TResponse>(responseString);
                return responseObject;
            }
            else
            {
                throw GenerateException(response);
            }
        }

        private Exception GenerateException(HttpResponseMessage response)
        {
            return new Exception($"HttpCode = {response.StatusCode}. Reason: {response.ReasonPhrase}");
        }

        private string GenerateQueryParameters<TRequest>(TRequest request)
        {
            var queryParameters = new StringBuilder("?");
            foreach (var property in request.GetType().GetProperties())
            {
                queryParameters.Append($"{property.Name.ToLower()}={property.GetValue(request)}&");
            }
            return queryParameters.ToString();
        }
    }
}
