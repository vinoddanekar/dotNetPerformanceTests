using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class HugeList_ForAndEach
    {
        private List<string> strings;
        public HugeList_ForAndEach()
        {
            DataRepository dataRepository = new DataRepository(DataRepository.Size.Huge);
            this.strings = dataRepository.GetDummyStringList();
        }

        [TestMethod]
        public void Test_For()
        {
            string dummyVariable;

            for (int index = 0; index < strings.Count; index++)
            {
                dummyVariable = strings[index];
            }
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Test_For_Each()
        {
            string dummyVariable;

            foreach (string item in strings)
            {
                dummyVariable = item;
            }
            Assert.IsTrue(true);
        }
    }
}
