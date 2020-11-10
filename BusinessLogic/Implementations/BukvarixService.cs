using BusinessLogic.Abstractions;
using Models.Requests;
using Models.Responses;
using Models.Settings;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class BukvarixService : IBukvarixService
    {
        private readonly IRestClient _restClient;
        private readonly BukvarixSettings _bukvarixSettings;

        public BukvarixService(IRestClient restClient,
            BukvarixSettings bukvarixSettings)
        {
            _restClient = restClient;
            _bukvarixSettings = bukvarixSettings;
        }

        public Task<BukvarixResponse> GetWordCombinations(string request)
        {
            var bukvarixRequest = new BukvarixRequest
            {
                Api_Key = _bukvarixSettings.ApiKey,
                Format = _bukvarixSettings.Format,
                Q = request
            };

            return _restClient.GetAsync<BukvarixRequest, BukvarixResponse>(_bukvarixSettings.Endpoint, bukvarixRequest);
        }
    }
}
