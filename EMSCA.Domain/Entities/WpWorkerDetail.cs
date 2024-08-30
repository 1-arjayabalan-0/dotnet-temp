using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class WpWorkerDetail
{
    public long WpWorkerDetailId { get; set; }

    public long WorkPermitId { get; set; }

    public string WorkerName { get; set; } = null!;

    public string? MailId { get; set; }

    public string MobileNo { get; set; } = null!;

    public int Status { get; set; }

    public virtual WorkPermit WorkPermit { get; set; } = null!;

    public virtual ICollection<WpWorkerDoc> WpWorkerDocs { get; set; } = new List<WpWorkerDoc>();
}
