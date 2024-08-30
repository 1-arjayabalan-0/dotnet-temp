using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class VisitorEntryDetail
{
    public long VisitorEntryDetailId { get; set; }

    public long VisitorEntryId { get; set; }

    public string VisitorEntryDetailCode { get; set; } = null!;

    public int? TitleId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public long? DepartmentId { get; set; }

    public DateTime? Dob { get; set; }

    public string? MailId { get; set; }

    public string MobileNo { get; set; } = null!;

    public int? IdCardType { get; set; }

    public string IdCardNo { get; set; } = null!;

    public string DocumentName { get; set; } = null!;

    public string DocumentUrl { get; set; } = null!;

    public int Status { get; set; }

    public bool? IsEditedImage { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public virtual VisitorEntry VisitorEntry { get; set; } = null!;
}
