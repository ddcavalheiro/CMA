using System.Threading.Tasks;
using Abp.Application.Services;
using CMA.Authorization.Accounts.Dto;

namespace CMA.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
