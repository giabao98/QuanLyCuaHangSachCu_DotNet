using Abp.AutoMapper;
using Ngt.Center.Localization.Dto;

namespace Ngt.Center.Web.Areas.App.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}