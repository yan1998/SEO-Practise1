using BusinessLogic.Abstractions;
using Models.Requests;
using Models.Responses;
using Models.Settings;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class GoogleTrendsService : IGoogleTrendsService
    {
        private readonly IRestClient _restClient;
        private readonly GoogleTrendsSettings _googleTrendsSettings;

        public GoogleTrendsService(IRestClient restClient,
            GoogleTrendsSettings googleTrendsSettings)
        {
            _restClient = restClient;
            _googleTrendsSettings = googleTrendsSettings;
        }

        public Task<GoogleTrendsResponse> GetTrends(string request)
        {
            var googleRequest = new GoogleTrendsRequest
            {
                Tz = _googleTrendsSettings.Tz,
                Token = _googleTrendsSettings.Token,
                Req = $"%7B%22time%22:%222019-11-08+2020-11-08%22,%22resolution%22:%22WEEK%22,%22locale%22:%22en-US%22,%22comparisonItem%22:%5B%7B%22geo%22:%7B%22country%22:%22US%22%7D,%22complexKeywordsRestriction%22:%7B%22keyword%22:%5B%7B%22type%22:%22BROAD%22,%22value%22:%22{request}%22%7D%5D%7D%7D%5D,%22requestOptions%22:%7B%22property%22:%22%22,%22backend%22:%22IZG%22,%22category%22:0%7D%7D"
            };

            return _restClient.GetAsync<GoogleTrendsRequest, GoogleTrendsResponse>(_googleTrendsSettings.Endpoint, googleRequest);
        }
    }
}
