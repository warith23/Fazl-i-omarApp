using Backend.Contract;
using Backend.Enums;

namespace Backend.Entities
{
    public class Result: AuditableEntity
    {
        public string SubjectName{get;set;}
        public double ContinuousAssessment{get;set;}
        public double ExamScore{get;set;}
        public Terms Terms{get;set;}
        public double TotalScore{get;set;}
        public string Grade{get;set;}
        public string Remark{get;set;}
    }
}