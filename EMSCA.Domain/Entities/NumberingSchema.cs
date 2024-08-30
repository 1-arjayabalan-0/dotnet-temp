using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class NumberingSchema
{
    public int NumberingSchemaId { get; set; }

    public int? VenueId { get; set; }

    public int DocumentId { get; set; }

    public string? Prefix { get; set; }

    public int? SymbolId { get; set; }

    public string? Suffix { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? SequenceName { get; set; }

    public string? WSequenceName { get; set; }

    public int? DateFormat { get; set; }

    public string? TableName { get; set; }
}
