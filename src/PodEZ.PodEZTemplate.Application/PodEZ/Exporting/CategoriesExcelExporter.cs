using System.Collections.Generic;
using Abp.Runtime.Session;
using Abp.Timing.Timezone;
using PodEZ.PodEZTemplate.DataExporting.Excel.EpPlus;
using PodEZ.PodEZTemplate.PodEz.Dtos;
using PodEZ.PodEZTemplate.Dto;
using PodEZ.PodEZTemplate.Storage;

namespace PodEZ.PodEZTemplate.PodEz.Exporting
{
    public class CategoriesExcelExporter : EpPlusExcelExporterBase, ICategoriesExcelExporter
    {

        private readonly ITimeZoneConverter _timeZoneConverter;
        private readonly IAbpSession _abpSession;

        public CategoriesExcelExporter(
            ITimeZoneConverter timeZoneConverter,
            IAbpSession abpSession,
			ITempFileCacheManager tempFileCacheManager) :  
	base(tempFileCacheManager)
        {
            _timeZoneConverter = timeZoneConverter;
            _abpSession = abpSession;
        }

        public FileDto ExportToFile(List<GetCategoryForViewDto> categories)
        {
            return CreateExcelPackage(
                "Categories.xlsx",
                excelPackage =>
                {
                    var sheet = excelPackage.Workbook.Worksheets.Add(L("Categories"));
                    sheet.OutLineApplyStyle = true;

                    AddHeader(
                        sheet,
                        L("CategoryName")
                        );

                    AddObjects(
                        sheet, 2, categories,
                        _ => _.Category.CategoryName
                        );

					

                });
        }
    }
}
