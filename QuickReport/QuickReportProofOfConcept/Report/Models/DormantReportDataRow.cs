namespace QuickReportProofOfConcept.Report.Models
{
    public class DormantReportDataRow
    {
        public string SerialNumber { get; set; }

        public string Name { get; set; }

        public string VehicleProfile { get; set; }

        public string Vin { get; set; }

        public string VehicleModel { get; set; }
        public string LastEngineRunDate { get; set; }

        public string DormantGap { get; set; }

        public string LastContactDate { get; set; }

        public string Location { get; set; }

        public string BatteryPercent { get; set; }

        public string PowerOffAlertTime { get; set; }

        public string CustomerNames { get; set; }

        public string DealerName { get; set; }
    }
}
