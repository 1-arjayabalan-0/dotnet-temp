using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class SupplierBillingdetail
{
    public long SupplierBillingId { get; set; }

    public long SupplierId { get; set; }

    public long CompanyId { get; set; }

    public int? VenueId { get; set; }

    public string BillingAddressOne { get; set; } = null!;

    public string BillingAddressTwo { get; set; } = null!;

    public long CityId { get; set; }

    public long StateId { get; set; }

    public long CountryId { get; set; }

    public string BillingPincode { get; set; } = null!;

    public string BillingContactPerson { get; set; } = null!;

    public string BillingPhoneOne { get; set; } = null!;

    public string BillingPhoneTwo { get; set; } = null!;

    public string BillingMobileNo { get; set; } = null!;

    public string BillingMailId { get; set; } = null!;

    public int? Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string DocumentName { get; set; } = null!;

    public string DocumentUrl { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
