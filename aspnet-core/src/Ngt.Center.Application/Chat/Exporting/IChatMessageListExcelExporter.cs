using System.Collections.Generic;
using Abp;
using Ngt.Center.Chat.Dto;
using Ngt.Center.Dto;

namespace Ngt.Center.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
