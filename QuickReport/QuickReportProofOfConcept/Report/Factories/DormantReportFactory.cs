using QuickReportProofOfConcept.Report.Reports;
using QuickReportProofOfConcept.Report.Interface;
using System.Collections.Generic;

namespace QuickReportProofOfConcept.Report.Factories
{
    public class DormantReportFactory : QuickReportFactory
    {
        public override IQuickReport CreateReport<DormantReportDataRow>(
            string columnHeaders, 
            IEnumerable<DormantReportDataRow> reportDataRow, 
            IEnumerable<string> columnsToHide)
        {
            return new DormantReport(columnHeaders, reportDataRow, columnsToHide);
        }
    }
}
