using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Ngt.Center.Configuration.Tenants.Dto;

namespace Ngt.Center.Web.Areas.App.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}