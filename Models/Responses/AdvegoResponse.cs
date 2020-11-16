using System.Collections.Generic;

namespace Models.Responses
{
    public class AdvegoResponse
    {
        public Dictionary<string, string> TextStatistic { get; set; }

        public Dictionary<string, SemanticValues> SemanticKernel { get; set; }
    }

    public class SemanticValues
    {
        public string Count { get; set; }

        public string Frequency { get; set; }
    }
}
