using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class HugeList_ForAndEach
    {
        private List<string> strings;
        [SetUp]
        public void Setup()
        {
            DataRepository dataRepository = new DataRepository(DataRepository.Size.Huge);
            this.strings = dataRepository.GetDummyStringList();
        }

        [Test]
        public void Test_For()
        {
            string dummyVariable;

            for (int index = 0; index < strings.Count; index++)
            {
                dummyVariable = strings[index];
            }
            Assert.IsTrue(true);
        }

        [Test]
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
