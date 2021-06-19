using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class DataTimeTests
    {
        private const long dateRangeIterations = 0b1_000_000;
        public DataTimeTests()
        {

        }

        [TestMethod]
        public void Test_CreateRangeUsingToStringFunction()
        {
            CreateRangeUsingToStringFunction();

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Test_CreateRangeUsingDateProperty()
        {
            CreateRangeUsingDateProperty();

            Assert.IsTrue(true);
        }

        private void CreateRangeUsingToStringFunction()
        {
            DateTime fromDate;
            DateTime toDate;

            for (long index = 0; index < dateRangeIterations; index++)
            {
                fromDate = DateTime.Now;
                toDate = fromDate.AddDays(1);

                fromDate = DateTime.Parse(fromDate.ToString("dd-MMM-yyyy"));
                toDate = DateTime.Parse(toDate.ToString("dd-MMM-yyyy"));
            }
        }

        private void CreateRangeUsingDateProperty()
        {
            DateTime fromDate;
            DateTime toDate;

            for (long index = 0; index < dateRangeIterations; index++)
            {
                fromDate = DateTime.Now;
                toDate = fromDate.AddDays(1);

                fromDate = fromDate.Date;
                toDate = toDate.Date;
            }
        }
    }
}
