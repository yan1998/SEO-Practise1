using Models.Responses;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IAdvegoService
    {
        Task<AdvegoResponse> AnalyzeText(string text);
    }
}
