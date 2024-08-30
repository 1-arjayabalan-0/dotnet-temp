using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class UserPlantMapView
{
    public long UserId { get; set; }

    public string UserName { get; set; } = null!;

    public long PlantId { get; set; }

    public string PlantName { get; set; } = null!;

    public bool? IsDefault { get; set; }

    public int Status { get; set; }
}
