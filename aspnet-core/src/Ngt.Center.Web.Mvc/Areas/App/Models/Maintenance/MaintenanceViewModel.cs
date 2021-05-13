using System.Collections.Generic;
using Ngt.Center.Caching.Dto;

namespace Ngt.Center.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}