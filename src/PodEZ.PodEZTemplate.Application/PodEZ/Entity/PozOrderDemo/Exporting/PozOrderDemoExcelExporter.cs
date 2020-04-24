using System.Collections.Generic;
using Abp.Runtime.Session;
using Abp.Timing.Timezone;
using PodEZ.PodEZTemplate.DataExporting.Excel.EpPlus;
using PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Dtos;
using PodEZ.PodEZTemplate.Dto;
using PodEZ.PodEZTemplate.Storage;

namespace PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Exporting
{
    public class PozOrderDemoExcelExporter : EpPlusExcelExporterBase, IPozOrderDemoExcelExporter
    {

        private readonly ITimeZoneConverter _timeZoneConverter;
        private readonly IAbpSession _abpSession;

        public PozOrderDemoExcelExporter(
            ITimeZoneConverter timeZoneConverter,
            IAbpSession abpSession,
			ITempFileCacheManager tempFileCacheManager) :  
	base(tempFileCacheManager)
        {
            _timeZoneConverter = timeZoneConverter;
            _abpSession = abpSession;
        }

        public FileDto ExportToFile(List<GetPozOrderDemoForViewDto> pozOrderDemo)
        {
            return CreateExcelPackage(
                "PozOrderDemo.xlsx",
                excelPackage =>
                {
                    var sheet = excelPackage.Workbook.Worksheets.Add(L("PozOrderDemo"));
                    sheet.OutLineApplyStyle = true;

                    AddHeader(
                        sheet,
                        L("PozOrderName"),
                        L("PozOrderDescription"),
                        L("PozImageTotal")
                        );

                    AddObjects(
                        sheet, 2, pozOrderDemo,
                        _ => _.PozOrderDemo.PozOrderName,
                        _ => _.PozOrderDemo.PozOrderDescription,
                        _ => _.PozOrderDemo.PozImageTotal
                        );

					

                });
        }
    }
}
