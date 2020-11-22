using System;
using System.Collections.Generic;

namespace _323Project2.Models
{
    public partial class JobInfo
    {
        public int EmployeeNumber { get; set; }
        public int JobRoleCode { get; set; }
        public string Department { get; set; }
        public int JobInvolvement { get; set; }
        public int JobSatisfaction { get; set; }
        public int JobLevel { get; set; }

        public virtual EmployeeDetail EmployeeNumberNavigation { get; set; }
        public virtual JobRole JobRoleCodeNavigation { get; set; }
    }
}
