using System.Collections.Generic;
using Ngt.Center.DynamicEntityParameters.Dto;

namespace Ngt.Center.Web.Areas.App.Models.DynamicParameters
{
    public class CreateOrEditDynamicParameterViewModel
    {
        public DynamicParameterDto DynamicParameterDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
