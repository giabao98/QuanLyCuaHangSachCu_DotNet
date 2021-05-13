using Abp.AutoMapper;
using Ngt.Center.MultiTenancy.Dto;

namespace Ngt.Center.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}