using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class UserScreenMapping
{
    public long UserScreenMappingId { get; set; }

    public long? UserId { get; set; }

    public long? RoleId { get; set; }

    public long? CompanyId { get; set; }

    public int ModuleId { get; set; }

    public int ScreenId { get; set; }

    public bool? Create { get; set; }

    public bool? Update { get; set; }

    public bool? Delete { get; set; }

    public bool? View { get; set; }

    public bool? Print { get; set; }

    public bool? Approval { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
