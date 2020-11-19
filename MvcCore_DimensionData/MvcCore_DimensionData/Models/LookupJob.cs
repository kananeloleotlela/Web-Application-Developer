using System;
using System.Collections.Generic;

namespace MvcCore_DimensionData.Models
{
    public partial class LookupJob
    {
        public short EmployeeNumber { get; set; }
        public int JobRoleCode { get; set; }
        public string Department { get; set; }
        public byte JobInvolvement { get; set; }
        public byte JobLevel { get; set; }
        public byte JobSatisfaction { get; set; }
    }
}
