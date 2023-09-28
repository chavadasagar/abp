using System.Threading.Tasks;
using Abp.Application.Services;
using Project.web.Sessions.Dto;

namespace Project.web.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
