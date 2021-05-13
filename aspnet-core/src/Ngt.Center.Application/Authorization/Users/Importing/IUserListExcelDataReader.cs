using System.Collections.Generic;
using Ngt.Center.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Ngt.Center.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
