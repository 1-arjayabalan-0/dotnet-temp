using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class UserPlantMap
{
    public long UserPlantMapId { get; set; }

    public long CompanyId { get; set; }

    public long UserId { get; set; }

    public long PlantId { get; set; }

    public int Status { get; set; }

    public int AccountingYear { get; set; }

    public bool? IsDefault { get; set; }

    public virtual User User { get; set; } = null!;
}
