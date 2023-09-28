using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.MultiTenancy;
using Project.web.MultiTenancy;
using System.ComponentModel.DataAnnotations;

namespace Project.web.Todo.Dto
{
    [AutoMapFrom(typeof(Todo))]
    public class TodoDto : EntityDto
    {
        [Required]
        [StringLength(AbpTenantBase.MaxNameLength)]
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}
