using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Material
{
    public long MaterialId { get; set; }

    public string MaterialCode { get; set; } = null!;

    public long MaterialType { get; set; }

    public long MaterialCategoryId { get; set; }

    public long MaterialSubCategoryId { get; set; }

    public string MaterialName { get; set; } = null!;

    public string BrandName { get; set; } = null!;

    public decimal PurchasePrice { get; set; }

    public string? MaterialImageName { get; set; }

    public string? MaterialImageUrl { get; set; }

    public int? Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int Uom { get; set; }
}
