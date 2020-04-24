using System.Collections.Generic;
using PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Dtos;
using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Exporting
{
    public interface IPozOrderDemoExcelExporter
    {
        FileDto ExportToFile(List<GetPozOrderDemoForViewDto> pozOrderDemo);
    }
}