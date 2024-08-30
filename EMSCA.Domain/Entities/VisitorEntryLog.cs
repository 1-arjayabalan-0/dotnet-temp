using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class VisitorEntryLog
{
    public long VisitorEntryLogId { get; set; }

    public long VisitorEntryDetailId { get; set; }

    public string VisitorEntryCode { get; set; } = null!;

    public DateTime CheckedIn { get; set; }

    public DateTime? CheckedOut { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
