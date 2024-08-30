using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class UserVenueMap
{
    public long UserVenueMapId { get; set; }

    public long CompanyId { get; set; }

    public long UserId { get; set; }

    public long VenueId { get; set; }

    public int Status { get; set; }

    public int AccountingYear { get; set; }

    public bool? IsDefault { get; set; }

    public virtual User User { get; set; } = null!;
}
