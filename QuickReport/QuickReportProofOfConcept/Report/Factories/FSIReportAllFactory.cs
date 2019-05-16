using QuickReportProofOfConcept.Report.Reports;
using QuickReportProofOfConcept.Report.Interface;
using System.Collections.Generic;

namespace QuickReportProofOfConcept.Report.Factories
{
    public class FSIReportAllFactory : QuickReportFactory
    {
        public override IQuickReport CreateReport<FsiAllReportDataRow>(
            string columnHeaders, 
            IEnumerable<FsiAllReportDataRow> reportDataRow, 
            IEnumerable<string> columnsToHide)
        {
            return new FSIAllReport(columnHeaders, reportDataRow, columnsToHide);
        }
    }
}
