using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace Project.web.Todo
{
    public class Todo : FullAuditedAggregateRoot<int>
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
