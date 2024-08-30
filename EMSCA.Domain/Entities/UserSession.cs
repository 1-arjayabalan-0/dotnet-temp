using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class UserSession
{
    public long UserSessionId { get; set; }

    public string SessionId { get; set; } = null!;

    public long LoggedUser { get; set; }

    public int LoggedRole { get; set; }

    public DateTime LoggedInOn { get; set; }

    public DateTime? LoggedOutOn { get; set; }

    public int SessionStatus { get; set; }

    public long? CompanyId { get; set; }

    public long? GateId { get; set; }

    public int? VenueId { get; set; }
}
