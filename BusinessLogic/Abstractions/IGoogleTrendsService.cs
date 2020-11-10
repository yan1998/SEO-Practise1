using Models.Responses;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IGoogleTrendsService
    {
        Task<GoogleTrendsResponse> GetTrends(string request);
    }
}
