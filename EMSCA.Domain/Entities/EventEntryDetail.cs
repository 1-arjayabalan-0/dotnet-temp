using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class EventEntryDetail
{
    public long EventEntryDetailId { get; set; }

    public long EventEntryId { get; set; }

    public string? EventEntryDetailCode { get; set; }

    public DateTime? EventEntryDate { get; set; }

    public int? TitleId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? DepartmentId { get; set; }

    public DateTime? Dob { get; set; }

    public string? MailId { get; set; }

    public string? MobileNo { get; set; }

    public int? IdCardType { get; set; }

    public string? IdCardNo { get; set; }

    public string? DocumentName { get; set; }

    public string? DocumentUrl { get; set; }

    public string? Notes { get; set; }

    public int? Status { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual EventEntry EventEntry { get; set; } = null!;
}
