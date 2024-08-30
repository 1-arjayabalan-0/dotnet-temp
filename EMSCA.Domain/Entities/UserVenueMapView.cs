using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class UserVenueMapView
{
    public long UserId { get; set; }

    public string UserName { get; set; } = null!;

    public long VenueId { get; set; }

    public string VenueName { get; set; } = null!;

    public bool? IsDefault { get; set; }

    public int Status { get; set; }
}
