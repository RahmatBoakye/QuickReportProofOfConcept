﻿using QuickReportProofOfConcept.Report.Interface;
using QuickReportProofOfConcept.Report.Utils;
using System.Collections.Generic;
using System.Linq;

namespace QuickReportProofOfConcept.Report.Reports
{
    public class DormantReport : IQuickReport
    {
        private readonly string _columnHeaders;
        private readonly IEnumerable<dynamic> _reportData;
        private readonly IEnumerable<string> _columnsToHide;
        public DormantReport(string columnHeaders,
            IEnumerable<dynamic> reportDataRow,
            IEnumerable<string> columnsToHide)
        {
            _columnHeaders = columnHeaders;
            _reportData = reportDataRow;
            _columnsToHide = columnsToHide;
        }

        public void GetReportAsCsv()
        {
            CsvUtils.ConvertToCSV(_columnHeaders, _reportData, _columnsToHide);
        }
    }
}
