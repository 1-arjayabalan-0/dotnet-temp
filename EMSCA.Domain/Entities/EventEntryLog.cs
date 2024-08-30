using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class EventEntryLog
{
    public long EventEntryLogId { get; set; }

    public long EventEntryDetailId { get; set; }

    public string EventEntryCode { get; set; } = null!;

    public DateTime CheckedIn { get; set; }

    public DateTime? CheckedOut { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
