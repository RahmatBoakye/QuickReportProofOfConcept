using QuickReportProofOfConcept.Report.Interface;
using System.Collections.Generic;

namespace QuickReportProofOfConcept.Report.Factories
{
    public abstract class QuickReportFactory
    {
        public abstract IQuickReport CreateReport<T>(
            string columnHeaders,
            IEnumerable<T> reportDataRow,
            IEnumerable<string> columnsToHide) where T : class;

    }
}
