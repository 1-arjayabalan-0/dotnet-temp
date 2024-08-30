using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class VehicleDocumentDetail
{
    public long VehicleDocumentDetailId { get; set; }

    public long VehicleId { get; set; }

    public string DocumentName { get; set; } = null!;

    public string DocumentNo { get; set; } = null!;

    public string? AttachmentUrl { get; set; }

    public string? AttachmentName { get; set; }

    public string? Remarks { get; set; }

    public virtual Vehicle Vehicle { get; set; } = null!;
}
