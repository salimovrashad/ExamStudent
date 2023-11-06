using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent
{
    internal class Exam
    {
        public string Student { get; set; }
        public int Point { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public override string ToString()
        {
            return $"Student: {Student}, Movzu: {Subject}, Point: {Point}, Duration: {StartTime.Hour - EndTime.Hour}";
        }
    }
}
