using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Project.web.MultiTenancy;

namespace Project.web.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
