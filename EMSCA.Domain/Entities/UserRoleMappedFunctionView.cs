using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class UserRoleMappedFunctionView
{
    public long? RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public long? UserId { get; set; }

    public string UserName { get; set; } = null!;

    public bool? Create { get; set; }

    public bool? Update { get; set; }

    public bool? Delete { get; set; }

    public bool? View { get; set; }

    public bool? Print { get; set; }

    public bool? Approval { get; set; }

    public int Pricehistory { get; set; }

    public int Profit { get; set; }

    public int Series { get; set; }

    public int Moduleid { get; set; }

    public string Modulename { get; set; } = null!;

    public int ScreenId { get; set; }

    public string Screenname { get; set; } = null!;

    public string? Path { get; set; }

    public int ScreenOrder { get; set; }
}
