using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTest
    {
        [TestMethod]
        public void VariablesHoldAReference()
        {
            //Testing to understand how reference values work
            Grades g1 = new Grades();

            //Setting g2 to the newly created instance g1 
            Grades g2 = g1;

            //g1.Name = "Divyesh's grade book";
            //Testing here to check both names are the same
           // Assert.AreEqual(g1.Name, g2.Name);
        }

    }
}
