using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class VisitorEntryBelongingDetail
{
    public long VisitorEntryBelongingDetailId { get; set; }

    public long VisitorEntryId { get; set; }

    public string DeviceNo { get; set; } = null!;

    public string DeviceName { get; set; } = null!;

    public virtual VisitorEntry VisitorEntry { get; set; } = null!;
}
