using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class GateDetail
{
    public long GateDetailId { get; set; }

    public long SecurityId { get; set; }

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public long GateId { get; set; }

    public string? Address { get; set; }

    public virtual Gate Gate { get; set; } = null!;
}
