using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades; //Including namespce Grades
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    //Here making use of the TestClass namespace as this is a Unit Testing class
    [TestClass]
    public class GradeBookTests
    {
        //********************** Test 1 **********************
        //Writing the method to be used to test for the Highest Grade
        [TestMethod]
        public void TestCalculate_ComputesHighestGrade_HigestGradeSucessfullyCalculates()
        {
            //New instance of Gradebook
            Grades book = new Grades();
            //Adding grades
            book.AddGrade(10);
            book.AddGrade(90);

            //Now time to get some statistics
            GradeStatistics result = GradeState.Calculate(book.GetGrades());
            Assert.AreEqual(90, result.HighestGrade);
            Assert.AreEqual(10, result.LowestGrade);
        }

        public void TestCalculate_ComputesHighestGrade_HigestGradeFailsToCalculate()
        {
            //New instance of Gradebook
            Grades book = new Grades();
            //Adding grades
            book.AddGrade(10);
            book.AddGrade(90);

            //Now time to get some statistics
            GradeStatistics result = GradeState.Calculate(book.GetGrades());
            Assert.AreEqual(90, result.HighestGrade);
            Assert.AreEqual(10, result.LowestGrade);
        }
        //*************************************************//

        //********************** Test 2 **********************
        //Writing the method to be used to test for the Lowest Grade
        [TestMethod]
        public void ComputesLowestGrade()
        {
            //New instance of Gradebook
            Grades book = new Grades();
            //Adding grades
            book.AddGrade(10);
            book.AddGrade(90);

            //Now time to get some statistics
            GradeStatistics result = GradeState.Calculate(book.GetGrades());
            Assert.AreEqual(10, result.LowestGrade);
        }
        //*************************************************//

        //********************** Test 3 **********************
        //Writing the method to be used to test for the Average Grade
        [TestMethod]
        public void ComputesAverageGrade()
        {
            //New instance of Gradebook
            Grades book = new Grades();
            //Adding grades
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            //Now time to get some statistics
            GradeStatistics result = GradeState.Calculate(book.GetGrades());
            //Using Delta for precision. Floating point number to match with a delta of 0.01
            Assert.AreEqual(85.16, result.AverageGrade, 0.01);
        }
        //*************************************************//
    }
}
