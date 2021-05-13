using System.Collections.Generic;
using Abp.Localization;
using Ngt.Center.Install.Dto;

namespace Ngt.Center.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
