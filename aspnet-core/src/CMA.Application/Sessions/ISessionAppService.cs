using System.Threading.Tasks;
using Abp.Application.Services;
using CMA.Sessions.Dto;

namespace CMA.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
