using System;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            highestGrade = 0;
            lowestGrade = float.MaxValue;
        }

        public float averageGrade;
        public float lowestGrade;
        public float highestGrade;
    }
}
