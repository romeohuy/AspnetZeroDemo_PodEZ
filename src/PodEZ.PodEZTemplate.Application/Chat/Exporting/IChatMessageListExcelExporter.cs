using System.Collections.Generic;
using Abp;
using PodEZ.PodEZTemplate.Chat.Dto;
using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
