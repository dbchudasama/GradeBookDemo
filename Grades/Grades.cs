using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class Grades
    {
        //Defining and initialising field. By making the List of grades private allows for Encapsulation.
        private List<float> grades = new List<float>();
        public IList<float> GetGrades()
        {
            return grades;
        }
                
        //Defining method AddGrade
        public void AddGrade(float grade)
        { 
            //Arithmetic operation using in built compiler function 'Add'. This will add grades to the List 'grades'. 
            grades.Add(grade);
        }
    }
}
