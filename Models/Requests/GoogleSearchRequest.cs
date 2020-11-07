namespace Models.Requests
{
    // Documentaion reference: https://developers.google.com/custom-search/v1/using_rest
    public class GoogleSearchRequest
    {
        public string Key { get; set; }

        public string Cx { get; set; }

        public string Q { get; set; }

        public short Num { get; set; }
    }
}
