using System;
using System.Collections.Generic;

namespace _323Project2.Models
{
    public partial class JobRole
    {
        public JobRole()
        {
            JobInfo = new HashSet<JobInfo>();
        }

        public int JobRoleCode { get; set; }
        public string Job { get; set; }

        public virtual ICollection<JobInfo> JobInfo { get; set; }
    }
}
