using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Shift
{
    public long ShiftId { get; set; }

    public string ShiftCode { get; set; } = null!;

    public long CompanyId { get; set; }

    public int? VenueId { get; set; }

    public string ShiftName { get; set; } = null!;

    public string ShiftType { get; set; } = null!;

    public DateTime ShiftFromTime { get; set; }

    public DateTime ShiftToTime { get; set; }

    public decimal? ShiftHours { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
