using AutoMapper;

namespace Project.web.Todo.Dto
{
    public class TodoMapProfile : Profile
    {
        public TodoMapProfile()
        {
            CreateMap<CreateTodoDto, Todo>().ReverseMap();
            CreateMap<TodoDto, Todo>().ReverseMap();
        }
    }
}
