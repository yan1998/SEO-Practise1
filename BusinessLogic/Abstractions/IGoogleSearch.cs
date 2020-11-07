using System.Threading.Tasks;
using Models.Responses;

namespace BusinessLogic.Abstractions
{
    public interface IGoogleSearch
    {
        Task<GoogleSearchResponse> Search(string request);
    }
}
