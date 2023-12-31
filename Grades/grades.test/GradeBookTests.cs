﻿using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades.test
{
    [TestClass]
    class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade ()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(10);
            book.AddGrade(90); 

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.AddGrade(95);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.AverageGrade);
        }

    }
}
