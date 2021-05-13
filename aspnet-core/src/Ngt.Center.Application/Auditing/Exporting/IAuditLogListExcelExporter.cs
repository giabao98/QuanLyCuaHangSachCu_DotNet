using System.Collections.Generic;
using Ngt.Center.Auditing.Dto;
using Ngt.Center.Dto;

namespace Ngt.Center.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
