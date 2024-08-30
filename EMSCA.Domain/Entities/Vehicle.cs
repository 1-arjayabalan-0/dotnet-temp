using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Vehicle
{
    public long VehicleId { get; set; }

    public string VehicleCode { get; set; } = null!;

    public string VehicleName { get; set; } = null!;

    public long CompanyId { get; set; }

    public long PlantId { get; set; }

    public int VehicleType { get; set; }

    public string VehicleNo { get; set; } = null!;

    public long? SupplierId { get; set; }

    public string? SupplierMobileNo { get; set; }

    public string? SupplierAddress { get; set; }

    public string VehicleModel { get; set; } = null!;

    public DateTime VehicleFcDate { get; set; }

    public DateTime ServiceDate { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? Remarks { get; set; }

    public virtual ICollection<VehicleDocumentDetail> VehicleDocumentDetails { get; set; } = new List<VehicleDocumentDetail>();
}
