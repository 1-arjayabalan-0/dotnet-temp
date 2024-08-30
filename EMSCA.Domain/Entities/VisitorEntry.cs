using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class VisitorEntry
{
    public long? CompanyId { get; set; }

    public int? VenueId { get; set; }

    public long? GateId { get; set; }

    public long VisitorEntryId { get; set; }

    public string VisitorEntryCode { get; set; } = null!;

    public DateTime VisitorEntryDate { get; set; }

    public long? VisitorTypeId { get; set; }

    public long? VisitorId { get; set; }

    public string? PersonName { get; set; }

    public string? MobileNo { get; set; }

    public long? IdProofType { get; set; }

    public string? IdProofNo { get; set; }

    public long? VisitedEmployeeId { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? AccessType { get; set; }

    public bool? IsExtended { get; set; }

    public bool? IsAppointmentBooking { get; set; }

    public int? IsPreBooking { get; set; }

    public string? VisitorRemarks { get; set; }

    public int? PurposeOfVisit { get; set; }

    public string? VisitorImageName { get; set; }

    public string? VisitorImageUrl { get; set; }

    public string? DcNumber { get; set; }

    public int? PartyType { get; set; }

    public long? PartyName { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? PoNumber { get; set; }

    public string? ContainerNumber { get; set; }

    public bool? IsExistingVehicle { get; set; }

    public string? VehicleName { get; set; }

    public string? VehicleNo { get; set; }

    public string? NumberOfPassengers { get; set; }

    public bool? IsExistingDriver { get; set; }

    public string? DriverId { get; set; }

    public string? VehicleDocumentName { get; set; }

    public string? VehicleDocumentUrl { get; set; }

    public long? RouteId { get; set; }

    public decimal? StartingKm { get; set; }

    public decimal? EndingKm { get; set; }

    public string? TagNo { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsExternal { get; set; }

    public bool? IsInternalAppointment { get; set; }

    public string? RefNo { get; set; }

    public virtual ICollection<VisitorEntryAtvDetail> VisitorEntryAtvDetails { get; set; } = new List<VisitorEntryAtvDetail>();

    public virtual ICollection<VisitorEntryBelongingDetail> VisitorEntryBelongingDetails { get; set; } = new List<VisitorEntryBelongingDetail>();

    public virtual ICollection<VisitorEntryDetail> VisitorEntryDetails { get; set; } = new List<VisitorEntryDetail>();

    public virtual ICollection<VisitorEntryMaterialDetail> VisitorEntryMaterialDetails { get; set; } = new List<VisitorEntryMaterialDetail>();
}
