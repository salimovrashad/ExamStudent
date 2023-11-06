namespace ExamStudent.Models
{
    internal class Exam : Student
    {
        public int Point { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public override string ToString()
        {
            return $"Student: {StudentName}, Subject: {Subject}, Point: {Point}, Duration: {StartTime.Hour - EndTime.Hour}-Hour";
        }
    }
}
