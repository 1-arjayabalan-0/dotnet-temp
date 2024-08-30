using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class SupplierType
{
    public long SupplierTypeId { get; set; }

    public string SupplierTypeName { get; set; } = null!;

    public string SupplierTypeCode { get; set; } = null!;

    public long CompanyId { get; set; }

    public long PlantId { get; set; }

    public int? Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
