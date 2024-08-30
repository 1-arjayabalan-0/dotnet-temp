using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class CustomerBillingDetail
{
    public long CustomerBillingDetailId { get; set; }

    public long CustomerId { get; set; }

    public string? BillingAddress1 { get; set; }

    public string? BillingAddress2 { get; set; }

    public long? CityId { get; set; }

    public long? StateId { get; set; }

    public long? CountryId { get; set; }

    public int? PinCode { get; set; }

    public string? ContactPerson { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? MobileNo { get; set; }

    public string? MailId { get; set; }

    public long CompanyId { get; set; }

    public int? VenueId { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
