using System;
using System.Collections.Generic;

namespace QuickReportProofOfConcept.Report.Utils
{
    /// <summary>
    /// csv utility class
    /// </summary>
	public static class CsvUtils
    {
        public static void ConvertToCSV<T>(string headers, IEnumerable<T> data, IEnumerable<string> columnsToHide = null) where T : class
        {
            Console.WriteLine(@"Headers -> {0}, Data -> {1}, HideColumns -> {2}", headers, data, columnsToHide);
        }
    }
}
