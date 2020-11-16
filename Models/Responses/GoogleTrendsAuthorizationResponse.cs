using System.Collections.Generic;

namespace Models.Responses
{
    public class GoogleTrendsAuthorizationResponse
    {
        public List<GoogleTrendsAuthorizationWidgets> Widgets { get; set; }
    }

    public class GoogleTrendsAuthorizationWidgets
    {
        public GoogleTrendsAuthorizationWidgetsRequest Request { get; set; }
        public string Token { get; set; }
    }

    public class GoogleTrendsAuthorizationWidgetsRequest
    {
        public string Time { get; set; }

        public string Resolution { get; set; }

        public string Locale { get; set; }

        public GoogleTrendsAUthorizationRequestOptions RequestOptions { get; set; }
    }

    public class GoogleTrendsAUthorizationRequestOptions
    {
        public string Backend { get; set; }
    }
}
