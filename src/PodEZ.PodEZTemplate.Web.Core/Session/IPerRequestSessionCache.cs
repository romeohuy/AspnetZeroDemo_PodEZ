using System.Threading.Tasks;
using PodEZ.PodEZTemplate.Sessions.Dto;

namespace PodEZ.PodEZTemplate.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
