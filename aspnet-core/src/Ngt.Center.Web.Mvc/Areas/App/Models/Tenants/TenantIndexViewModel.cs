using System.Collections.Generic;
using Ngt.Center.Editions.Dto;

namespace Ngt.Center.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}