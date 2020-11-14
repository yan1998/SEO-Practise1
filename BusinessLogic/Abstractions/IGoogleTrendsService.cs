using Models.Enums;
using Models.Responses;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IGoogleTrendsService
    {
        Task<GoogleTrendsDataResponse> GetTrendsForPeriod(string request, GoogleTrendsPeriod period);
    }
}
