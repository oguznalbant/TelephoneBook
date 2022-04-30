using Report.Api.Enums;

namespace Report.Api.Entities
{
    public class Report
    {
        public DateTime RequestDate { get; set; }

        public ReportState State { get; set; }
    }
}
