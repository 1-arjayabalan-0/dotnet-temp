using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class ApprovalConfiguration
{
    public long ApprovalConfigurationId { get; set; }

    public long CompanyId { get; set; }

    public int? VenueId { get; set; }

    public long DocumentId { get; set; }

    public int ApprovalActivityId { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<ApprovalConfigurationDetail> ApprovalConfigurationDetails { get; set; } = new List<ApprovalConfigurationDetail>();
}
