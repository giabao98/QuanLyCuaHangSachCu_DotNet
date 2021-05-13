using Abp.AutoMapper;
using Ngt.Center.MultiTenancy;
using Ngt.Center.MultiTenancy.Dto;
using Ngt.Center.Web.Areas.App.Models.Common;

namespace Ngt.Center.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}