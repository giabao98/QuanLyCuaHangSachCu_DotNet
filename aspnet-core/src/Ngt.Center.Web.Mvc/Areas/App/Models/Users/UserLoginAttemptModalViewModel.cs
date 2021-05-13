using System.Collections.Generic;
using Ngt.Center.Authorization.Users.Dto;

namespace Ngt.Center.Web.Areas.App.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}