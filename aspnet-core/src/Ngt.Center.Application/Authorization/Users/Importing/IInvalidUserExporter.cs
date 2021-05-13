using System.Collections.Generic;
using Ngt.Center.Authorization.Users.Importing.Dto;
using Ngt.Center.Dto;

namespace Ngt.Center.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
