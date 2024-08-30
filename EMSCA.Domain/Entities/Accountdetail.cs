using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Accountdetail
{
    public long Accountid { get; set; }

    public string Accountholdername { get; set; } = null!;

    public string Bankname { get; set; } = null!;

    public long Accountnumber { get; set; }

    public long Ifsccode { get; set; }

    public string? Docname { get; set; }

    public string? Docurl { get; set; }

    public long Vendorid { get; set; }

    public int Createdby { get; set; }

    public DateTime Createdon { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public int Status { get; set; }

    public virtual Vendor Vendor { get; set; } = null!;
}
