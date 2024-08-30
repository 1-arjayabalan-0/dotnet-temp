using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class State
{
    public long StateId { get; set; }

    public long CountryId { get; set; }

    public string StateName { get; set; } = null!;

    public string StateCode { get; set; } = null!;

    public int? Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
