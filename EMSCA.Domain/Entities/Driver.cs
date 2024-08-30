using System;
using System.Collections.Generic;

namespace EMSCA.Infrastructure.Data;

public partial class Driver
{
    public long DriverId { get; set; }

    public string DriverCode { get; set; } = null!;

    public long EmpId { get; set; }

    public long SuppId { get; set; }

    public DateTime Dob { get; set; }

    public int Age { get; set; }

    public string DrivingLicenceNo { get; set; } = null!;

    public DateTime LicenseValidity { get; set; }

    public string HeavyBatchNo { get; set; } = null!;

    public DateTime BatchValidity { get; set; }

    public int DriverMobileNo { get; set; }

    public string NationalIdNo { get; set; } = null!;

    public string ContactAddress { get; set; } = null!;

    public string EmergencyContactName { get; set; } = null!;

    public int EmergencyContactNo { get; set; }

    public string DocumentRefrenceName { get; set; } = null!;

    public string UploadDocument { get; set; } = null!;

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
