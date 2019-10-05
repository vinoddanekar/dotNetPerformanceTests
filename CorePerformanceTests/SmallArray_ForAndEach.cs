using NUnit.Framework;

namespace Tests
{
    public class SmallArray_ForAndEach
    {
        private string[] strings;
        [SetUp]
        public void Setup()
        {
            DataRepository dataRepository = new DataRepository(DataRepository.Size.Small);
            this.strings = dataRepository.GetDummyStringArray();
        }

        [Test]
        public void Test_For()
        {
            string dummyVariable;

            for (int index = 0; index < strings.Length; index++)
            {
                dummyVariable = strings[index];
            }
            Assert.Pass();
        }

        [Test]
        public void Test_For_Each()
        {
            string dummyVariable;

            foreach (string item in strings)
            {
                dummyVariable = item;
            }
            Assert.Pass();
        }
    }
}