using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Gate
{
    public long GateId { get; set; }

    public string? GateName { get; set; }

    public string? GateCode { get; set; }

    public string? GateNo { get; set; }

    public long? GateInchargeId { get; set; }

    public DateTime? GateOpenTime { get; set; }

    public DateTime? GateCloseTime { get; set; }

    public long? CompanyId { get; set; }

    public int? VenueId { get; set; }

    public int? Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<GateDetail> GateDetails { get; set; } = new List<GateDetail>();
}
