﻿using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {


        public GradeBook()
        {
            grades = new List<float>();

        }


        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach(var grade in grades)
            {
                stats.highestGrade = Math.Max(grade, stats.highestGrade);
                stats.lowestGrade = Math.Min(grade, stats.lowestGrade);
                sum += grade;
            }

            stats.averageGrade = sum / grades.Count;

            return stats;
        }

        private List<float> grades;
    }
}
