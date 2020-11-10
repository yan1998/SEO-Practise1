using Models.Responses;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IBukvarixService
    {
        Task<BukvarixResponse> GetWordCombinations(string request);
    }
}
