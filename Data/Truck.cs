using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppTestSynfusion.Data
{
    public class Truck
    {
        public string VehicleRegNo { get; set; } = null!;
        public decimal? UnladenWeight { get; set; }
        //public string? Remarks { get; set; }
        //public float? Flowrate { get; set; }
        //public string? TruckType { get; set; }
        //public string? Transporter { get; set; }
        //public Boolean? IsBlack { get; set; }
        public Boolean? Active { get; set; }
        //public string? LoadingType { get; set; }
        //public DateTime? BlackDate { get; set; }
        //public DateTime? BlackRemovedDate { get; set; }
        //public int? CompartmentNo { get; set; }
        //public string? DriverLicenseNo { get; set; }
        //public DateTime? LastLoadingDate { get; set; }
        //public string? VehicleBackRegNo { get; set; }
        //public int RFIDCode { get; set; }
        //public int TotalNrDomeCover { get; set; }
        //public int TotalNrLoadCoupling { get; set; }
        //public int TotalNrFootValve { get; set; }
        //public int TotalNrCabinet { get; set; }
        //public string? OtherSealPlace { get; set; }
        //public string? BlackReason { get; set; }
        //public string? BlackRemovedReason { get; set; }
        //public string? UpdatedUser { get; set; }
        //public string? CreatedUser { get; set; }
        //public DateTime? UpdatedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
