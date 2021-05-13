using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Ngt.Center.Editions.Dto;

namespace Ngt.Center.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}