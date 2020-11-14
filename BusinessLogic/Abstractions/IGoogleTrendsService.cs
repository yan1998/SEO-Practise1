using Models.Responses;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IGoogleTrendsService
    {
        Task<GoogleTrendsDataResponse> GetTrends(string request);
    }
}
