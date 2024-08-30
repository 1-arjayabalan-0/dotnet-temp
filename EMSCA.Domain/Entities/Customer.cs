using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Customer
{
    public long CustomerId { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public long? CountryId { get; set; }

    public long? StateId { get; set; }

    public long? CityId { get; set; }

    public long? CompanyId { get; set; }

    public int? VenueId { get; set; }

    public int? Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? CustomerImageName { get; set; }

    public string? CustomerImageUrl { get; set; }

    public string? ContactPerson { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<CustomerBillingDetail> CustomerBillingDetails { get; set; } = new List<CustomerBillingDetail>();
}
