using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class UserGateMap
{
    public long UserGateMapId { get; set; }

    public long CompanyId { get; set; }

    public long UserId { get; set; }

    public int? VenueId { get; set; }

    public long GateId { get; set; }

    public int Status { get; set; }

    public int AccountingYear { get; set; }

    public bool? IsDefault { get; set; }

    public virtual User User { get; set; } = null!;
}
