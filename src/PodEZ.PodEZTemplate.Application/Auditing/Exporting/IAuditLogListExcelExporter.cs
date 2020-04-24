using System.Collections.Generic;
using PodEZ.PodEZTemplate.Auditing.Dto;
using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
