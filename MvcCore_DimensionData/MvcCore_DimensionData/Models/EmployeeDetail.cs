using System;
using System.Collections.Generic;

namespace MvcCore_DimensionData.Models
{
    public partial class EmployeeDetail
    {
        public EmployeeDetail()
        {
            EmployeeEducationInfo = new HashSet<EmployeeEducationInfo>();
            EmployeeHistory = new HashSet<EmployeeHistory>();
            JobInfo = new HashSet<JobInfo>();
        }

        public int EmployeeNumber { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public int EmployeeCount { get; set; }

        public virtual ICollection<EmployeeEducationInfo> EmployeeEducationInfo { get; set; }
        public virtual ICollection<EmployeeHistory> EmployeeHistory { get; set; }
        public virtual ICollection<JobInfo> JobInfo { get; set; }
    }
}
