using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class VisitorEntryMaterialDetail
{
    public long VisitorEntryMaterialDetailId { get; set; }

    public long VisitorEntryId { get; set; }

    public long MaterialId { get; set; }

    public int Uom { get; set; }

    public string Qty { get; set; } = null!;

    public virtual VisitorEntry VisitorEntry { get; set; } = null!;
}
