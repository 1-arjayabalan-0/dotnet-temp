using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Department
{
    public long DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public string? DepartmentCode { get; set; }

    public long CompanyId { get; set; }

    public int? VenueId { get; set; }

    public int? Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
