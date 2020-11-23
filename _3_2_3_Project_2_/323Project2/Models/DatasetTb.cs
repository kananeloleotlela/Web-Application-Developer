using System;
using System.Collections.Generic;

namespace _323Project2.Models
{
    public partial class DatasetTb
    {
        public byte Age { get; set; }
        public bool Attrition { get; set; }
        public string BusinessTravel { get; set; }
        public short DailyRate { get; set; }
        public string Department { get; set; }
        public byte DistanceFromHome { get; set; }
        public byte Education { get; set; }
        public string EducationField { get; set; }
        public byte EmployeeCount { get; set; }
        public short EmployeeNumber { get; set; }
        public byte EnvironmentSatisfaction { get; set; }
        public string Gender { get; set; }
        public byte HourlyRate { get; set; }
        public byte JobInvolvement { get; set; }
        public byte JobLevel { get; set; }
        public string JobRole { get; set; }
        public byte JobSatisfaction { get; set; }
        public string MaritalStatus { get; set; }
        public short MonthlyIncome { get; set; }
        public short MonthlyRate { get; set; }
        public byte NumCompaniesWorked { get; set; }
        public string Over18 { get; set; }
        public bool OverTime { get; set; }
        public byte PercentSalaryHike { get; set; }
        public byte PerformanceRating { get; set; }
        public byte RelationshipSatisfaction { get; set; }
        public byte StandardHours { get; set; }
        public byte StockOptionLevel { get; set; }
        public byte TotalWorkingYears { get; set; }
        public byte TrainingTimesLastYear { get; set; }
        public byte WorkLifeBalance { get; set; }
        public byte YearsAtCompany { get; set; }
        public byte YearsInCurrentRole { get; set; }
        public byte YearsSinceLastPromotion { get; set; }
        public byte YearsWithCurrManager { get; set; }
    }
}
