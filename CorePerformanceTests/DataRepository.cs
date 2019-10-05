using System.Collections.Generic;

namespace Tests
{
    class DataRepository
    {
        public enum Size
        {
            Small = 1000,
            Huge = 10000000
        }

        private Size dataSize;
        public DataRepository(Size dataSize)
        {
            this.dataSize = dataSize;
        }

        public string[] GetDummyStringArray()
        {
            string[] strings = new string[(long)dataSize];

            for (int index = 0; index < strings.Length; index++)
            {
                strings[index] = "String " + index.ToString();
            }

            return strings;
        }

        public List<string> GetDummyStringList()
        {
            List<string> strings = new List<string>();

            for (int index = 0; index < (long)dataSize; index++)
            {
                strings.Add("String " + index.ToString());
            }

            return strings;
        }
    }
}
