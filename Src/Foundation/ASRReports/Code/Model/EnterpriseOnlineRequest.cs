using System;

namespace M1CP.Feature.ASRReports.Model
{

    public partial class EnterpriseOnlineRequest
    {
  
        public int CustomerID { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CampaignName { get; set; }

        public string CompanyName { get; set; }

        public string CompanyBRN { get; set; }

        public string CustomerName { get; set; }

        public string ContactNumber { get; set; }

        public string CustomerEmail { get; set; }

        public string SelectedDate { get; set; }

        public string SelectedTime { get; set; }

        public string SelectedVenue { get; set; }

        public string StaffStrength { get; set; }

        public string SpecialReq { get; set; }

        public string AccManager { get; set; }

        public string CustomerDetail1 { get; set; }

        public string CustomerDetail2 { get; set; }

        public string MobileNumber { get; set; }
    }
}
