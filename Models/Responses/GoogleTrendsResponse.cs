using System.Collections.Generic;

namespace Models.Responses
{
    public class GoogleTrendsResponse
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

        public List<long> Value { get; set; }
    }
}
