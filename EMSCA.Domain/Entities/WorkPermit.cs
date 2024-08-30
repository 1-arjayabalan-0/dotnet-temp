using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class WorkPermit
{
    public long? CompanyId { get; set; }

    public int? VenueId { get; set; }

    public long? GateId { get; set; }

    public long WorkPermitId { get; set; }

    public string WorkPermitCode { get; set; } = null!;

    public DateTime WorkPermitDate { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? ContractorName { get; set; }

    public long? WorkOrganizer { get; set; }

    public string? PoNo { get; set; }

    public string? StatusRemarks { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public long DocStatus { get; set; }

    public virtual ICollection<WpCompanyDoc> WpCompanyDocs { get; set; } = new List<WpCompanyDoc>();

    public virtual ICollection<WpWorkerDetail> WpWorkerDetails { get; set; } = new List<WpWorkerDetail>();
}
