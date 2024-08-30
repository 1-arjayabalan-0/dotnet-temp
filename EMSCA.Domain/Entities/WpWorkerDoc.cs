using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class WpWorkerDoc
{
    public long? CompanyId { get; set; }

    public int? VenueId { get; set; }

    public long? GateId { get; set; }

    public long WpWorkerDocId { get; set; }

    public long WpWorkerDetailId { get; set; }

    public string DocumentName { get; set; } = null!;

    public string DocumentNo { get; set; } = null!;

    public string? DocumentUrl { get; set; }

    public string? Remarks { get; set; }

    public long Status { get; set; }

    public virtual WpWorkerDetail WpWorkerDetail { get; set; } = null!;
}
