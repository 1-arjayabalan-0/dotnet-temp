using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Event
{
    public long EventId { get; set; }

    public long VenueId { get; set; }

    public long CompanyId { get; set; }

    public long HostId { get; set; }

    public string EventCode { get; set; } = null!;

    public int EventTypeId { get; set; }

    public int EventVisibilityId { get; set; }

    public long EventCategoryId { get; set; }

    public long EventTcId { get; set; }

    public int PolicyGroupId { get; set; }

    public string EventName { get; set; } = null!;

    public string? EventDescription { get; set; }

    public DateTime EventStartDate { get; set; }

    public DateTime EventEndDate { get; set; }

    public string EventLocation { get; set; } = null!;

    public int MaxVisitors { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public string? ApprovalRemarks { get; set; }

    public int DocStatus { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int AccountingYear { get; set; }

    public virtual ICollection<EventDocumentDetail> EventDocumentDetails { get; set; } = new List<EventDocumentDetail>();
}
