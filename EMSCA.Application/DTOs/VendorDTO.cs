using System.Collections.Generic;
using EMSCA.Domain.Entities;
using EMSCA.Infrastructure.CommonEntities;

namespace EMSCA.Application.DTOs
{
    public class VendorDTO
    {
         public Vendor vendor { get; set; }
        public List<Accountdetail> vendorAccDetails { get; set; }
        public List<Documentdetail> vendorDocDetails { get; set; }
        public List<Vendor> vendorLists { get; set; }
        public ErrorContext transtatus { get; set; }

        public List<Metadata> statusLists { get; set; }

        public List<Metadata> vendorTypeLists { get; set; }

        public List<Metadata> documentTypeLists { get; set; }

    }
}
