using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class RoleWiseScreenMappingView
{
    public long? RoleId { get; set; }

    public int ScreenId { get; set; }

    public string ScreenName { get; set; } = null!;

    public int ModuleId { get; set; }

    public string ModuleName { get; set; } = null!;
}
