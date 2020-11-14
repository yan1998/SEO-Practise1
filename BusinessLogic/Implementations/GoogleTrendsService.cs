using BusinessLogic.Abstractions;
using Models.Requests;
using Models.Responses;
using Models.Settings;
using System;
using System.Linq;
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

        public async Task<GoogleTrendsDataResponse> GetTrends(string request)
        {
            var authorizationResponse = await Authorize(request);
            var googleRequest = new GoogleTrendsDataRequest
            {
                Tz = _googleTrendsSettings.Tz,
                Token = authorizationResponse.Token,
                Req = $"%7B%22time%22:%22{authorizationResponse.Request.Time}%22,%22resolution%22:%22WEEK%22,%22locale%22:%22en-US%22,%22comparisonItem%22:%5B%7B%22geo%22:%7B%7D,%22complexKeywordsRestriction%22:%7B%22keyword%22:%5B%7B%22type%22:%22BROAD%22,%22value%22:%22{request}%22%7D%5D%7D%7D%5D,%22requestOptions%22:%7B%22property%22:%22%22,%22backend%22:%22IZG%22,%22category%22:0%7D%7D"
            };

            return await _restClient.GetAsync<GoogleTrendsDataRequest, GoogleTrendsDataResponse>(_googleTrendsSettings.DataEndpoint, googleRequest);
        }

        private async Task<GoogleTrendsAuthorizationWidgets> Authorize(string request)
        {
            var authorizationRequest = new GoogleTrendsAuthorizationRequest
            {
                Hl = _googleTrendsSettings.Hl,
                Tz = _googleTrendsSettings.Tz,
                Req = $"%7B%22comparisonItem%22:%5B%7B%22keyword%22:%22{request}%22,%22geo%22:%22%22,%22time%22:%22today+12-m%22%7D%5D,%22category%22:0,%22property%22:%22%22%7D"
            };

            var response = await _restClient.GetAsync<GoogleTrendsAuthorizationRequest, GoogleTrendsAuthorizationResponse>(_googleTrendsSettings.AuthorizationEndpoint, authorizationRequest);
            return response.Widgets.First();
        }
    }
}
