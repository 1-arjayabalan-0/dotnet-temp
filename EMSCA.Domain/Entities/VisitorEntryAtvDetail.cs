using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class VisitorEntryAtvDetail
{
    public long VisitorEntryAtvDetailId { get; set; }

    public long VisitorEntryId { get; set; }

    public long AreaToVisit { get; set; }

    public virtual VisitorEntry VisitorEntry { get; set; } = null!;
}
