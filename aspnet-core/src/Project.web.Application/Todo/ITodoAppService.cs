using Abp.Application.Services;
using Project.web.Todo.Dto;

namespace Project.web.Todo
{
    public interface ITodoAppService : IAsyncCrudAppService<TodoDto, int, PagedTodoResultRequestDto, CreateTodoDto, TodoDto>
    {
    }
}
