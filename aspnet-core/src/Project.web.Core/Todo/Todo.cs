using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.MultiTenancy;
using System;

namespace Project.web.Todo
{
    public class Todo : FullAuditedAggregateRoot<int>
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}
