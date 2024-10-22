using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CMA.Roles.Dto;
using CMA.Users.Dto;

namespace CMA.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
