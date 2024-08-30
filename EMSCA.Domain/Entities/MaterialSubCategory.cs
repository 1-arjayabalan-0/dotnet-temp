using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class MaterialSubCategory
{
    public long MaterialSubCategoryId { get; set; }

    public string MaterialSubCategoryCode { get; set; } = null!;

    public string MaterialSubCategoryName { get; set; } = null!;

    public long MaterialCategoryId { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
