using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class VisitInformation
{
    public long? CompanyId { get; set; }

    public long? PlantId { get; set; }

    public long? GateId { get; set; }

    public long VisitId { get; set; }

    public string VisitCode { get; set; } = null!;

    public long? VisitTypeId { get; set; }

    public DateTime VisitEntryDate { get; set; }

    public string? PersonName { get; set; }

    public string? MobileNo { get; set; }

    public long? WhomToVisitId { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? PurposeOfVisit { get; set; }

    public string? VisitRemarks { get; set; }

    public string? VisitImageName { get; set; }

    public string? VisitImageUrl { get; set; }

    public string? DriverId { get; set; }

    public string? VehicleName { get; set; }

    public string? VehicleNo { get; set; }

    public string? VehicleDocumentName { get; set; }

    public string? VehicleDocumentUrl { get; set; }

    public long? RouteId { get; set; }

    public decimal? CurrentKm { get; set; }

    public sbyte? IsExtended { get; set; }

    public sbyte? IsAppointmentBooking { get; set; }

    public sbyte? IsExistingVehicle { get; set; }

    public sbyte? IsExistingDriver { get; set; }

    public sbyte IsExternal { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public long? VehicleType { get; set; }

    public virtual VisitInformationDetail? VisitInformationDetail { get; set; }
}
