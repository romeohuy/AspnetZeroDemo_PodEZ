using System.Collections.Generic;
using PodEZ.PodEZTemplate.PodEz.Dtos;
using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.PodEz.Exporting
{
    public interface ICategoriesExcelExporter
    {
        FileDto ExportToFile(List<GetCategoryForViewDto> categories);
    }
}