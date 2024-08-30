using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class VisitorDetail
{
    public long VisitorDetailId { get; set; }

    public long VisitorId { get; set; }

    public string VisitorDetailCode { get; set; } = null!;

    public int TitleId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public long? DepartmentId { get; set; }

    public DateTime? Dob { get; set; }

    public string? MailId { get; set; }

    public string MobileNo { get; set; } = null!;

    public int IdCardType { get; set; }

    public string IdCardNo { get; set; } = null!;

    public string DocumentName { get; set; } = null!;

    public string DocumentUrl { get; set; } = null!;

    public DateTime? ExpirryDate { get; set; }

    public int? WorkSeverity { get; set; }

    public int Status { get; set; }

    public string? TagNo { get; set; }

    public virtual Visitor Visitor { get; set; } = null!;
}
