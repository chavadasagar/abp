using System.Threading.Tasks;
using Abp.Application.Services;
using Project.web.Authorization.Accounts.Dto;

namespace Project.web.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
