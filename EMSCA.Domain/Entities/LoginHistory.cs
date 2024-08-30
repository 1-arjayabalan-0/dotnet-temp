using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class LoginHistory
{
    public long LoginHistoryId { get; set; }

    public long UserId { get; set; }

    public string Password { get; set; } = null!;

    public bool IsActive { get; set; }
}
