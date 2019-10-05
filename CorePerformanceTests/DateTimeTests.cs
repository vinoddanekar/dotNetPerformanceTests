using System;
using NUnit.Framework;

namespace Tests
{
    public class DataTimeTests
    {
        private const long dateRangeIterations = 1000000;
        
        [Test]
        public void Test_CreateRangeUsingToStringFunction()
        {
            CreateRangeUsingToStringFunction();

            Assert.Pass();
        }

        [Test]
        public void Test_CreateRangeUsingDateProperty()
        {
            CreateRangeUsingDateProperty();

            Assert.Pass();
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
