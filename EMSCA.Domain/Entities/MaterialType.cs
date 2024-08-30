using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class MaterialType
{
    public long MaterialTypeId { get; set; }

    public string MaterialTypeName { get; set; } = null!;

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
