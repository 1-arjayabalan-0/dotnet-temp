using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Company
{
    public long CompanyId { get; set; }

    public string? CompanyCode { get; set; }

    public string CompanyName { get; set; } = null!;

    public int? Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public long? CountryId { get; set; }

    public long? CityId { get; set; }

    public long? StateId { get; set; }

    public string? Mail { get; set; }

    public string? Host { get; set; }

    public string? Port { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }
}
