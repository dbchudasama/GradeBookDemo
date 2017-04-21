using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeState
    {
        public static GradeStatistics Calculate(IList<float> grades)
        {
            return new GradeStatistics()
            {
                HighestGrade = grades.Max(),
                LowestGrade = grades.Min(),
                AverageGrade = grades.Sum() / grades.Count
            };
        }
    }
}
