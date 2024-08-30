using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Country
{
    public long CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public string? CountryCode { get; set; }

    public string CountryShortForm { get; set; } = null!;

    public string Nationality { get; set; } = null!;

    public int? Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
