using BusinessLogic.Abstractions;
using Models.Enums;
using Models.Requests;
using Models.Responses;
using Models.Settings;
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

        public async Task<GoogleTrendsDataResponse> GetTrendsForPeriod(string request, GoogleTrendsPeriod period)
        {
            request = request.Trim();
            var authorizationResponse = await Authorize(request, period);
            var googleRequest = new GoogleTrendsDataRequest
            {
                Tz = _googleTrendsSettings.Tz,
                Token = authorizationResponse.Token,
                Req = $"%7B%22time%22:%22{authorizationResponse.Request.Time.Replace("\\", "%5C%5C").Replace(' ', '+')}%22,%22resolution%22:%22{authorizationResponse.Request.Resolution}%22,%22locale%22:%22{authorizationResponse.Request.Locale}%22,%22comparisonItem%22:%5B%7B%22geo%22:%7B%7D,%22complexKeywordsRestriction%22:%7B%22keyword%22:%5B%7B%22type%22:%22BROAD%22,%22value%22:%22{request}%22%7D%5D%7D%7D%5D,%22requestOptions%22:%7B%22property%22:%22%22,%22backend%22:%22{authorizationResponse.Request.RequestOptions.Backend}%22,%22category%22:0%7D%7D"
            };

            return await _restClient.GetAsync<GoogleTrendsDataRequest, GoogleTrendsDataResponse>(_googleTrendsSettings.DataEndpoint, googleRequest);
        }

        private async Task<GoogleTrendsAuthorizationWidgets> Authorize(string request, GoogleTrendsPeriod period)
        {
            string periodRequest = string.Empty;
            switch (period)
            {
                case GoogleTrendsPeriod.Past5Years:
                    periodRequest = "today+5-y";
                    break;
                case GoogleTrendsPeriod.PastYear:
                    periodRequest = "today+12-m";
                    break;
                case GoogleTrendsPeriod.Past3Months:
                    periodRequest = "today+3-m";
                    break;
                case GoogleTrendsPeriod.PastMonth:
                    periodRequest = "today+1-m";
                    break;
                case GoogleTrendsPeriod.PastWeek:
                    periodRequest = "now+7-d";
                    break;
                case GoogleTrendsPeriod.PastDay:
                    periodRequest = "now+1-d";
                    break;
            }
            var authorizationRequest = new GoogleTrendsAuthorizationRequest
            {
                Hl = _googleTrendsSettings.Hl,
                Tz = _googleTrendsSettings.Tz,
                Req = $"%7B%22comparisonItem%22:%5B%7B%22keyword%22:%22{request}%22,%22geo%22:%22%22,%22time%22:%22{periodRequest}%22%7D%5D,%22category%22:0,%22property%22:%22%22%7D"
            };

            var response = await _restClient.GetAsync<GoogleTrendsAuthorizationRequest, GoogleTrendsAuthorizationResponse>(_googleTrendsSettings.AuthorizationEndpoint, authorizationRequest);
            return response.Widgets.First();
        }
    }
}
