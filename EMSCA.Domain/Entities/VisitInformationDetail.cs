using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class VisitInformationDetail
{
    public long? CompanyId { get; set; }

    public long? PlantId { get; set; }

    public long? GateId { get; set; }

    public long VisitorDetailId { get; set; }

    public long VisitId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public long? DepartmentId { get; set; }

    public DateTime? Dob { get; set; }

    public string MailId { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string DocumentName { get; set; } = null!;

    public DateTime? ExpiryDate { get; set; }

    public int? WorkSeverity { get; set; }

    public int Status { get; set; }

    public virtual ICollection<VisitLog> VisitLogs { get; set; } = new List<VisitLog>();

    public virtual VisitInformation VisitorDetail { get; set; } = null!;
}
