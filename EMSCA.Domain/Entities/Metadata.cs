using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Metadata
{
    public long MetaSubId { get; set; }

    public string MetaTypeCode { get; set; } = null!;

    public string MetaSubCode { get; set; } = null!;

    public string MetaTypeName { get; set; } = null!;

    public string MetaSubDescription { get; set; } = null!;

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
