using Abp.Application.Services.Dto;

namespace Project.web.Todo.Dto
{
    public class PagedTodoResultRequestDto: PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
