using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Visitor
{
    public long VisitorId { get; set; }

    public string VisitorCode { get; set; } = null!;

    public long VisitorTypeId { get; set; }

    public long CompanyId { get; set; }

    public int? VenueId { get; set; }

    public long? CountryId { get; set; }

    public long? StateId { get; set; }

    public long? CityId { get; set; }

    public int TitleId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public DateTime Dob { get; set; }

    public string? VisitorCompany { get; set; }

    public string? Address { get; set; }

    public string MailId { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public int? IdCardType { get; set; }

    public string? IdCardNo { get; set; }

    public string DocumentName { get; set; } = null!;

    public string DocumentUrl { get; set; } = null!;

    public string? VisitorDocumentName { get; set; }

    public string? VisitorDocumentUrl { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<VisitorDetail> VisitorDetails { get; set; } = new List<VisitorDetail>();
}
