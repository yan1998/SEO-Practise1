using BusinessLogic.Abstractions;
using HtmlAgilityPack;
using Models.Requests;
using Models.Responses;
using Models.Settings;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class AdvegoService : IAdvegoService
    {
        private readonly IRestClient _restClient;
        private readonly AdvegoSettings _advegoSettings;

        public AdvegoService(IRestClient restClient,
            AdvegoSettings advegoSettings)
        {
            _restClient = restClient;
            _advegoSettings = advegoSettings;
        }

        public async Task<AdvegoResponse> AnalyzeText(string text)
        {
            var advegoRequest = new AdvegoRequest
            {
                Job_text = text,
                Id_lang = 0
            };

            var htmlPage = await _restClient.PostAsync(_advegoSettings.Endpoint, advegoRequest);

            // From String
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(htmlPage);

            var response = new AdvegoResponse
            {
                SemanticKernel = new Dictionary<string, SemanticValues>(),
                TextStatistic = new Dictionary<string, string>()
            };
            var seoTables = htmlDoc.DocumentNode.SelectNodes("//table[@class='seo_table']");

            var textStatisticTable = seoTables[0];
            foreach (var tr in textStatisticTable.SelectNodes("tr"))
            {
                var tds = tr.SelectNodes("td");
                if (tds != null && tds.Count != 0)
                    response.TextStatistic.Add(tds[0].InnerText.Trim(), tds[1].InnerText.Trim());
            }

            var semanticKernelTable = seoTables[1];
            foreach (var tr in semanticKernelTable.SelectNodes("tr"))
            {
                var tds = tr.SelectNodes("td");
                if (tds != null && tds.Count != 0)
                {
                    response.SemanticKernel.Add(tds[0].InnerText.Trim(),
                      new SemanticValues
                      {
                          Count = tds[1].InnerText.Trim(),
                          Frequency = tds[2].InnerText.Trim()
                      });
                }
            }

            return response;
        }
    }
}
