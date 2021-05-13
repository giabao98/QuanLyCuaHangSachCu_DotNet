using Abp.Auditing;
using Ngt.Center.Configuration.Dto;

namespace Ngt.Center.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}