using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Documentdetail
{
    public long Documentid { get; set; }

    public long? Documentype { get; set; }

    public string Documentnumber { get; set; } = null!;

    public string? Documentname { get; set; }

    public string? Documenturl { get; set; }

    public long Vendorid { get; set; }

    public int Createdby { get; set; }

    public DateTime Createdon { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public int Status { get; set; }

    public virtual Vendor Vendor { get; set; } = null!;
}
