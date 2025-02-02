using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class ApprovalConfigurationDetail
{
    public long ApprovalConfigurationDetailId { get; set; }

    public long ApprovalConfigurationId { get; set; }

    public int LevelId { get; set; }

    public long RoleId { get; set; }

    public long PrimaryUserId { get; set; }

    public long? SecondaryUserId { get; set; }

    public virtual ApprovalConfiguration ApprovalConfiguration { get; set; } = null!;
}
