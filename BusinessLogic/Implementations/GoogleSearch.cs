using System.Threading.Tasks;
using BusinessLogic.Abstractions;
using Models.Requests;
using Models.Responses;
using Models.Settings;

namespace BusinessLogic.Implementations
{
    public class GoogleSearch : IGoogleSearch
    {
        private readonly GoogleSearchSettings _googleSearchSettings;
        private readonly IRestClient _restClient;

        public GoogleSearch(GoogleSearchSettings googleSearchSettings,
            IRestClient restClient)
        {
            _googleSearchSettings = googleSearchSettings;
            _restClient = restClient;
        }

        public Task<GoogleSearchResponse> Search(string request)
        {
            var googleRequest = new GoogleSearchRequest
            {
                Cx = _googleSearchSettings.Cx,
                Key = _googleSearchSettings.ApiKey,
                Num = 10,
                Q = request
            };

            return _restClient.GetAsync<GoogleSearchRequest, GoogleSearchResponse>(_googleSearchSettings.Endpoint, googleRequest);
        }
    }
}
