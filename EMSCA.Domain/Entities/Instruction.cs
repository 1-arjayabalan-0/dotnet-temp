using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Instruction
{
    public long InstructionsId { get; set; }

    public long CompanyId { get; set; }

    public int? VenueId { get; set; }

    public long VisitorTypeId { get; set; }

    public string TextInput { get; set; } = null!;

    public int? Status { get; set; }
}
