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
    }
}
