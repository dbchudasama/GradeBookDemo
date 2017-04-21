using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        //Constructor to store values for Hightest and Lowest Grades to be used to compare values against
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
