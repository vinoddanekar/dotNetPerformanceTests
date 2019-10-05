using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class HugeArray_ForAndEach
    {
        private string[] strings;
        public HugeArray_ForAndEach()
        {
            DataRepository dataRepository = new DataRepository(DataRepository.Size.Huge);
            this.strings = dataRepository.GetDummyStringArray();
        }

        [TestMethod]
        public void Test_For()
        {
            string dummyVariable;

            for (int index = 0; index < strings.Length; index++)
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
