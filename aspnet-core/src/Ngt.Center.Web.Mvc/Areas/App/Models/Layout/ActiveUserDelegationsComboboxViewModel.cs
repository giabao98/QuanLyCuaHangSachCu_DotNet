using System.Collections.Generic;
using Ngt.Center.Authorization.Delegation;
using Ngt.Center.Authorization.Users.Delegation.Dto;

namespace Ngt.Center.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
