using Abp.AutoMapper;
using Ngt.Center.Organizations.Dto;

namespace Ngt.Center.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}