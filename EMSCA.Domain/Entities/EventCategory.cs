using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class EventCategory
{
    public long EventCategoryId { get; set; }

    public string EventCategoryName { get; set; } = null!;

    public string? EventCategoryImageName { get; set; }

    public string? EventCategoryImageUrl { get; set; }

    public int Status { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
