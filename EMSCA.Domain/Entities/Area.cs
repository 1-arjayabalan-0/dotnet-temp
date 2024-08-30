using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Area
{
    public long AreaId { get; set; }

    public string? AreaCode { get; set; }

    public string AreaName { get; set; } = null!;

    public long? CompanyId { get; set; }

    public int? VenueId { get; set; }

    public int? Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
