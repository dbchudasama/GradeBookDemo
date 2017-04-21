using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {

        //Defining default constructor
        public GradeBook()
        {
            grades = new List<float>();
        }

        //Method which entails the computation of varies statistics to be calculated
        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            //************************************* Calculating Average score *************************************

            //Initialising to '0'
            float sum = 0;

            //Looping through each grade in the grade collection
            foreach(float grade in grades)
            {
                //Using in built Math functions to set Highest and Lowest grades
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                //Will add the value of the grade into the sum variable
                sum += grade;

                //AVERAGE Calculated by taking the sum value and dividing this by the number of grades in the list
                stats.AverageGrade = sum / grades.Count;
            }

            //**************************************************************************************************//
            return stats;
        }
                
        //Defining method AddGrade
        public void AddGrade (float grade)
        { 
            //Arithmetic operation using in built compiler function 'Add'. This will add grades to the List 'grades'. 
            grades.Add(grade);
        }

        public string Name;

        //Defining and initialising field. By making the List of grades private allows for Encapsulation.
        private List<float> grades; 
    }
}
