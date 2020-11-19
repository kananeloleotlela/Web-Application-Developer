using System;
using System.Collections.Generic;

namespace MvcCore_DimensionData.Models
{
    public partial class LookupEducation
    {
        public short EmployeeNumber { get; set; }
        public int EducationCode { get; set; }
        public byte Education { get; set; }
    }
}
