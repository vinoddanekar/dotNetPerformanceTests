﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SmallArray_ForAndEach
    {
        private string[] strings;
        public SmallArray_ForAndEach()
        {
            DataRepository dataRepository = new DataRepository(DataRepository.Size.Small);
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
