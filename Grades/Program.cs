using System;

namespace Grades
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(77f);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.averageGrade);
            Console.WriteLine(stats.lowestGrade);
            Console.WriteLine(stats.highestGrade);
        }

    }
}
