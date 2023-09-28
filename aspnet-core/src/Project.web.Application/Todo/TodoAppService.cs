using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Project.web.Authorization;
using Project.web.MultiTenancy;
using Project.web.MultiTenancy.Dto;
using Project.web.Todo.Dto;
using System.Threading.Tasks;

namespace Project.web.Todo
{
    [AbpAuthorize(PermissionNames.Pages_Todo)]
    public class TodoAppService : AsyncCrudAppService<Todo, TodoDto, int, PagedTodoResultRequestDto, CreateTodoDto, TodoDto>, ITodoAppService
    {
        public TodoAppService(IRepository<Todo, int> repository) : base(repository)
        {
        }
    }
}
