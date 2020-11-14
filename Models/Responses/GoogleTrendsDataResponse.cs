using System.Collections.Generic;

namespace Models.Responses
{
    public class GoogleTrendsDataResponse
    {
        public GoogleTrendsDefault Default { get; set; }
    }

    public class GoogleTrendsDefault
    {
        public List<TrendsItem> TimelineData { get; set; }
    }

    public class TrendsItem
    {
        public string FormattedAxisTime { get; set; }

        public string FormattedTime { get; set; }

        public List<long> Value { get; set; }
    }
}
