using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class UserRoleMap
{
    public long UserRoleMapId { get; set; }

    public short CompanyId { get; set; }

    public long UserId { get; set; }

    public short RoleId { get; set; }

    public int Status { get; set; }

    public long AccountingYear { get; set; }

    public bool? IsDefault { get; set; }

    public virtual User User { get; set; } = null!;
}
