using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class User
{
    public long UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public long CompanyId { get; set; }

    public int? VenueId { get; set; }

    public long? DefaultRoleId { get; set; }

    public string? UserEmail { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsBlocked { get; set; }

    public string? UserImageName { get; set; }

    public string? UserImageUrl { get; set; }

    public long? GateId { get; set; }

    public string? SecondaryMobileNo { get; set; }

    public string? Address { get; set; }

    public long? DeptId { get; set; }

    public string? UserCode { get; set; }

    public string? UserTelNo { get; set; }

    public virtual ICollection<UserBranchMap> UserBranchMaps { get; set; } = new List<UserBranchMap>();

    public virtual ICollection<UserCompanyMap> UserCompanyMaps { get; set; } = new List<UserCompanyMap>();

    public virtual ICollection<UserGateMap> UserGateMaps { get; set; } = new List<UserGateMap>();

    public virtual ICollection<UserPlantMap> UserPlantMaps { get; set; } = new List<UserPlantMap>();

    public virtual ICollection<UserRoleMap> UserRoleMaps { get; set; } = new List<UserRoleMap>();

    public virtual ICollection<UserVenueMap> UserVenueMaps { get; set; } = new List<UserVenueMap>();
}
