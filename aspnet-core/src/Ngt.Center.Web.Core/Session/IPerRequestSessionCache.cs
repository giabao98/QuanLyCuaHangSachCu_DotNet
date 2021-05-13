using System.Threading.Tasks;
using Ngt.Center.Sessions.Dto;

namespace Ngt.Center.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
