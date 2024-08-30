using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class EventDocumentDetail
{
    public long EventDocumentDetailId { get; set; }

    public long EventId { get; set; }

    public string DocumentType { get; set; } = null!;

    public string? DocumentNo { get; set; }

    public string? AttachmentUrl { get; set; }

    public string? AttachmentName { get; set; }

    public string? Remarks { get; set; }

    public int Status { get; set; }

    public virtual Event Event { get; set; } = null!;
}
