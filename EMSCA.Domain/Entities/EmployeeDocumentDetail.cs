using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class EmployeeDocumentDetail
{
    public long EmployeeDocumentDetailId { get; set; }

    public long EmployeeId { get; set; }

    public string DocumentName { get; set; } = null!;

    public string DocumentNo { get; set; } = null!;

    public string? AttachmentUrl { get; set; }

    public string? AttachmentName { get; set; }

    public string? Remarks { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
