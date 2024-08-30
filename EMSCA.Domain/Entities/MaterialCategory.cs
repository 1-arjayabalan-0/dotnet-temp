using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class MaterialCategory
{
    public long MaterialCategoryId { get; set; }

    public string MaterialCategoryName { get; set; } = null!;

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
