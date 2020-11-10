namespace Models.Requests
{
    // Documentation reference: https://www.bukvarix.com/api_keywords.html
    public class BukvarixRequest
    {
        public string Q { get; set; }

        public string Api_Key { get; set; }

        public string Format { get; set; }
    }
}
