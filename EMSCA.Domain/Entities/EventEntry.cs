using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class EventEntry
{
    public long EventEntryId { get; set; }

    public long VenueId { get; set; }

    public long EventId { get; set; }

    public long? GateId { get; set; }

    public long? CompanyId { get; set; }

    public string? EventEntryCode { get; set; }

    public DateTime? EventEntryDate { get; set; }

    public int? VisitorTypeId { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? AccessType { get; set; }

    public int? IsExtended { get; set; }

    public int? IsAppointmentBooking { get; set; }

    public string? VisitorRemarks { get; set; }

    public int? PurposeOfVisit { get; set; }

    public string? VisitorImageName { get; set; }

    public string? VisitorImageUrl { get; set; }

    public bool? IsExistingVehicle { get; set; }

    public int? NumberOfPassengers { get; set; }

    public string? VehicleDocumentName { get; set; }

    public string? VehicleDocumentUrl { get; set; }

    public int? StartingKm { get; set; }

    public int? EndingKm { get; set; }

    public bool? IsExternal { get; set; }

    public string? RefNo { get; set; }

    public int? Status { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<EventEntryDetail> EventEntryDetails { get; set; } = new List<EventEntryDetail>();
}
