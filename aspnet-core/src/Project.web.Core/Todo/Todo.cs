using Abp.Domain.Entities;

namespace Project.web.Todo
{
    public class Todo : Entity<int>
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}
