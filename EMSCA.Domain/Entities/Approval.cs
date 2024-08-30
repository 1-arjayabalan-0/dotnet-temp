using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Approval
{
    public long ApprovalId { get; set; }

    public int? VenueId { get; set; }

    public long DocumentId { get; set; }

    public string DocumentNo { get; set; } = null!;

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<ApprovalDetail> ApprovalDetails { get; set; } = new List<ApprovalDetail>();
}
