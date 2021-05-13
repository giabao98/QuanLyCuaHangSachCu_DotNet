using Abp.AutoMapper;
using Ngt.Center.MultiTenancy.Dto;

namespace Ngt.Center.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
