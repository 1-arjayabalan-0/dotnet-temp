using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class WpCompanyDoc
{
    public long? CompanyId { get; set; }

    public int? VenueId { get; set; }

    public long? GateId { get; set; }

    public long WpCompanyDocId { get; set; }

    public long WorkPermitId { get; set; }

    public string DocumentName { get; set; } = null!;

    public string DocumentNo { get; set; } = null!;

    public string? DocumentUrl { get; set; }

    public string? Remarks { get; set; }

    public long Status { get; set; }

    public virtual WorkPermit WorkPermit { get; set; } = null!;
}
