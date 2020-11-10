using System.Collections.Generic;

namespace Models.Responses
{
    // Documentaion reference: https://developers.google.com/custom-search/v1/using_rest
    public class GoogleSearchResponse
    {
        public List<SearchItem> Items { get; set; }
    }

    public class SearchItem
    {
        public string Title { get; set; }

        public string Link { get; set; }

        public string DisplayLink { get; set; }

        public string Snippet { get; set; }
    }
}
