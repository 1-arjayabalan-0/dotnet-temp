using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Venue
{
    public long VenueId { get; set; }

    public string VenueCode { get; set; } = null!;

    public string VenueName { get; set; } = null!;

    public string MaxCapacity { get; set; } = null!;

    public int VenueType { get; set; }

    public string? Address { get; set; }

    public string GeoLocation { get; set; } = null!;

    public long CountryId { get; set; }

    public long CityId { get; set; }

    public long StateId { get; set; }

    public long CompanyId { get; set; }

    public string? UrlToken { get; set; }

    public string? CheckToken { get; set; }

    public bool? IsAutomaticApprove { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
