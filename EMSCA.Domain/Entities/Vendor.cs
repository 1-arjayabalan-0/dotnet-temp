using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Vendor
{
    public long Vendorid { get; set; }

    public long? Vendortypeid { get; set; }

    public string Vendorname { get; set; } = null!;

    public string Companyname { get; set; } = null!;

    public long Primarycontactno { get; set; }

    public long Secondarycontactno { get; set; }

    public string? Mailid { get; set; }

    public string Address { get; set; } = null!;

    public int Createdby { get; set; }

    public DateTime Createdon { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public int Status { get; set; }

    public virtual ICollection<Accountdetail> Accountdetails { get; set; } = new List<Accountdetail>();

    public virtual ICollection<Documentdetail> Documentdetails { get; set; } = new List<Documentdetail>();
}
