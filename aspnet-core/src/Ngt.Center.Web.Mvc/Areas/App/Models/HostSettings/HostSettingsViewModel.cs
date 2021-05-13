using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Ngt.Center.Configuration.Host.Dto;
using Ngt.Center.Editions.Dto;

namespace Ngt.Center.Web.Areas.App.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}