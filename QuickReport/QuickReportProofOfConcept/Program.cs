using QuickReportProofOfConcept.Report;
using QuickReportProofOfConcept.Report.Models;
using System;
using System.Collections.Generic;

namespace QuickReportProofOfConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProcessDormantReportFactoryMethod();
            ProcessFSIAllReportReportFactoryMethod();
            Console.Read();
        }

        static void ProcessDormantReportFactoryMethod()
        {
            string columnHeaders = "Col 1, Col 2, Col 3";
            var reportData = new List<DormantReportDataRow>();
            var ListOfColumnsToHide = new List<string> { "Col 2", "Col 4" };

            QuickReport
                .InitializeFactories()
                .ExecuteCreation(QuickReportType.DormantReport, columnHeaders, reportData, ListOfColumnsToHide)
                .GetReportAsCsv();

        }

        static void ProcessFSIAllReportReportFactoryMethod()
        {
            string columnHeaders = "Col 1, Col 2, Col 3";
            var reportData = new List<FSIAllReportDataRow>();
            var ListOfColumnsToHide = new List<string> { "Col 2", "Col 4" };

            QuickReport
                .InitializeFactories()
                .ExecuteCreation(QuickReportType.DormantReport, columnHeaders, reportData, ListOfColumnsToHide)
                .GetReportAsCsv();

        }
    }
}
