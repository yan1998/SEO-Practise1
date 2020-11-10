using System.Threading.Tasks;
using Models.Responses;

namespace BusinessLogic.Abstractions
{
    public interface IGoogleSearchService
    {
        Task<GoogleSearchResponse> Search(string request);
    }
}
