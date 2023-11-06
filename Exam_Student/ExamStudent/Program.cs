using ExamStudent.Models;

namespace ExamStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();

            while (true)
            {
                Console.WriteLine("Choose option: \n1.Add exam. \n2.All exams. \n3.List of exams with more than 50 points. \n4.Exams in 1 week. \n5.Exams lasting less than 1 hour.");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Exam exam = new Exam();
                        Console.WriteLine("Student Name: ");
                        exam.StudentName = Console.ReadLine();
                        Console.WriteLine("Exam subject: ");
                        exam.Subject = Console.ReadLine();
                        Console.WriteLine("Student point: ");
                        exam.Point = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Start time (yyyy-MM-dd HH:mm:ss): ");
                        exam.StartTime = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("End time (yyyy-MM-dd HH:mm:ss): ");
                        exam.EndTime = DateTime.Parse(Console.ReadLine());
                        exams.Add(exam);
                        break;
                    case 2:
                        foreach (var item in exams)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 3:
                        var result50 = exams.FindAll(e => e.Point > 50);
                        foreach (var item in result50)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 4:
                        var result7 = exams.FindAll(e => DateTime.Now.Day - e.StartTime.Day <= 7);
                        foreach (var item in result7)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 5:
                        var result1 = exams.FindAll(e => e.StartTime.Hour - e.EndTime.Hour > 1);
                        foreach (var item in result1)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                }
            }
        }
    }
}