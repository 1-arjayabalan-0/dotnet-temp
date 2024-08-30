using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class NumberingSchemaSearchView
{
    public int NumberingSchemaId { get; set; }

    public string FunctionName { get; set; } = null!;

    public int FunctionId { get; set; }

    public string? Prefix { get; set; }

    public string? Suffix { get; set; }

    public string StatusName { get; set; } = null!;

    public int? DateFormat { get; set; }

    public string DateFormatName { get; set; } = null!;

    public int? SymbolId { get; set; }

    public string SymbolName { get; set; } = null!;

    public int Status { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
