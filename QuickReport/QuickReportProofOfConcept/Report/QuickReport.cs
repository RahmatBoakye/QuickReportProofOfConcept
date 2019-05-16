using QuickReportProofOfConcept.Report.Factories;
using QuickReportProofOfConcept.Report.Interface;
using System;
using System.Collections.Generic;

namespace QuickReportProofOfConcept.Report
{
    public class QuickReport
    {
        private readonly Dictionary<QuickReportType, QuickReportFactory> _factories;

        private QuickReport()
        {
            _factories = new Dictionary<QuickReportType, QuickReportFactory>();

            foreach (QuickReportType reportType in Enum.GetValues(typeof(QuickReportType)))
            {
                var factory = (QuickReportFactory) Activator.CreateInstance(Type.GetType("QuickReportProofOfConcept.Report.Factories." 
                    + Enum.GetName(typeof(QuickReportType), reportType) + "Factory"));

                _factories.Add(reportType,factory);
            }
        }

        public static QuickReport InitializeFactories() => new QuickReport();

        public IQuickReport ExecuteCreation(QuickReportType reportType,string columnHeaders,IEnumerable<dynamic> reportData,IEnumerable<string> columnsToHide) 
            => _factories[reportType].CreateReport(columnHeaders, reportData, columnsToHide);
    }
}
