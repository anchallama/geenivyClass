using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreenIvy.DSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenIvy.DSA.Tests
{
    [TestClass()]
    public class StackTest
    {
        [TestMethod()]
        public void InitialObjectCreation()
        {
            Stack s = new Stack();
            Assert.AreEqual(0, s.count);
            foreach (var item in s.store)
            {
                Assert.AreEqual(0, item);
            }
        }

        [TestMethod()]
        public void AfterEntryOfSingleObject()
        {
            Stack s = new Stack();
            s.Push(1);
            Assert.AreEqual(1, s.store[0]);
            Assert.AreEqual(1, s.count);
            var temp = s.Pop();
            Assert.AreEqual(1, temp);
            Assert.AreEqual(0, s.count);
            
        }

        [TestMethod()]
        [ExpectedException(typeof(StackOverflowException),"exception is expected as stack size is 10.")]
        public void ExceptionTesting()
        {
            Stack s = new Stack();
            for (int i = 0; i < 11; i++)
            {
                s.Push(i);
            }

        }

    }
}