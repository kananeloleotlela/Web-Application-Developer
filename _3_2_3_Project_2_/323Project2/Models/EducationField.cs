using System;
using System.Collections.Generic;

namespace _323Project2.Models
{
    public partial class EducationField
    {
        public EducationField()
        {
            EmployeeEducationInfo = new HashSet<EmployeeEducationInfo>();
        }

        public int EducationCode { get; set; }
        public string EducationDescription { get; set; }

        public virtual ICollection<EmployeeEducationInfo> EmployeeEducationInfo { get; set; }
    }
}
