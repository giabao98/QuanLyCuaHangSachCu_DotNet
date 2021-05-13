﻿using System.Collections.Generic;
using Ngt.Center.DynamicEntityParameters.Dto;

namespace Ngt.Center.Web.Areas.App.Models.EntityDynamicParameters
{
    public class CreateEntityDynamicParameterViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicParameterDto> DynamicParameters { get; set; }
    }
}
