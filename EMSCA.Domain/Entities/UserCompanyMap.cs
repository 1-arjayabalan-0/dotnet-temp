using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class UserCompanyMap
{
    public long UserCompanyId { get; set; }

    public int CompanyId { get; set; }

    public long UserId { get; set; }

    public int Status { get; set; }

    public int AccountingYear { get; set; }

    public bool? IsDefault { get; set; }

    public virtual User User { get; set; } = null!;
}
