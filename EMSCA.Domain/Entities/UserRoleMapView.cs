using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class UserRoleMapView
{
    public long UserId { get; set; }

    public string UserName { get; set; } = null!;

    public long RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public bool? IsDefault { get; set; }

    public int Status { get; set; }
}
