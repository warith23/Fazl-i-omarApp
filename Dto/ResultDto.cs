using Backend.Enums;

namespace Backend.Dto
{
    public class ResultDto
    {
        public Guid Id { get; set; }
        public string SubjectName { get; set; }
        public double ContinuousAssessment { get; set; }
        public double ExamScore { get; set; }
        public Terms Terms { get; set; }
        public double TotalScore { get; set; }
        public string Grade { get; set; }
        public string Remark { get; set; }
    }
}