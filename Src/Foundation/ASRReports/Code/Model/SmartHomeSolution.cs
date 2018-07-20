namespace M1CP.Feature.ASRReports.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class SmartHomeSolution
    {
        [Key]
        public int CustomerID { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CampaignName { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string NRIC { get; set; }

        [StringLength(50)]
        public string ContactNumber { get; set; }

        [StringLength(50)]
        public string AltContactNumber { get; set; }

        [StringLength(50)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string BlockNum { get; set; }

        [StringLength(50)]
        public string FloorNum { get; set; }

        [StringLength(50)]
        public string UnitNum { get; set; }

        [StringLength(100)]
        public string StreetName { get; set; }

        [StringLength(100)]
        public string ApartmentName { get; set; }

        public bool? SmartHomeSecurity { get; set; }

        public bool? SmartHealthcare { get; set; }

        public bool? SmartLighting { get; set; }

        [StringLength(50)]
        public string SelectedDate { get; set; }

        [StringLength(100)]
        public string CustomerDetail1 { get; set; }

        [StringLength(50)]
        public string CustomerDetail2 { get; set; }

        public bool? OwnerOccupied { get; set; }

        public bool? FeedbackAcceptance { get; set; }
    }
}
