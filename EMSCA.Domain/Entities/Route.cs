using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Route
{
    public long RouteId { get; set; }

    public string? RouteCode { get; set; }

    public string RouteName { get; set; } = null!;

    public string? RouteDesc { get; set; }

    public decimal? RouteDistanceInKm { get; set; }

    public string? FromLocation { get; set; }

    public string? ToLocation { get; set; }

    public long? CompanyId { get; set; }

    public int? VenueId { get; set; }

    public int? Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
