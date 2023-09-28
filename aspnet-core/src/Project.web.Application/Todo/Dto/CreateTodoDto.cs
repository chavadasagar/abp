using System.ComponentModel.DataAnnotations;

namespace Project.web.Todo.Dto
{
    public class CreateTodoDto
    {

        [Required]
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
