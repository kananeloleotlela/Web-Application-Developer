using System;
using System.Collections.Generic;

namespace MvcCore_DimensionData.Models
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
