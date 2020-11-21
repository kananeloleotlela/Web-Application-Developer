using System;
using System.Collections.Generic;

namespace _323Project2.Models
{
    public partial class EmployeeEducationInfo
    {
        public int EmployeeNumber { get; set; }
        public int EducationCode { get; set; }
        public int EducationCount { get; set; }

        public virtual EducationField EducationCodeNavigation { get; set; }
        public virtual EmployeeDetail EmployeeNumberNavigation { get; set; }
    }
}
