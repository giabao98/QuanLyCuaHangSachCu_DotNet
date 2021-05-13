using System.Collections.Generic;
using Ngt.Center.Authorization.Users.Dto;
using Ngt.Center.Dto;

namespace Ngt.Center.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}