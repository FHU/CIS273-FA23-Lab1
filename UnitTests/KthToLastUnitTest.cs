using Microsoft.VisualStudio.TestTools.UnitTesting;
//using LinkedList;

namespace KthToLast
{
    [TestClass]
    public class KthToLastUnitTest
    {
        [TestMethod]
        public void SingleInt1()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i <= 40; i++)
            {
                linkedList.AddLast(i);
            }
            
            for (int i = 0; i <= 40; i++)
            {
                Assert.AreEqual((40 - i), linkedList.KthToLastSinglyLinked(i));
            }
        }

        [TestMethod]
        public void DoubleInt1()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i <= 40; i++)
            {
                linkedList.AddLast(i);
            }

            for (int i = 0; i <= 40; i++)
            {
                Assert.AreEqual((40 - i), linkedList.KthToLastDoublyLinked(i));
            }
        }

        [TestMethod]
        public void SingleInt2()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(0);
            Assert.AreEqual((0), linkedList.KthToLastSinglyLinked(0));
        }

        [TestMethod]
        public void DoubleInt2()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(0);
            Assert.AreEqual((0), linkedList.KthToLastDoublyLinked(0));
        }

        [TestMethod]
        public void DoubleChar1()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast('a');
            Assert.AreEqual(('a'), linkedList.KthToLastDoublyLinked(0));
        }

        [TestMethod]
        public void SingleChar1()
        {
            LinkedList<char> linkedList = new LinkedList<char>();
            linkedList.AddLast('a');
            Assert.AreEqual(('a'), linkedList.KthToLastDoublyLinked(0));
        }

        [TestMethod]
        public void DoubleChar2()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 097; i < 123; i++)
            {
                linkedList.AddLast((char)i);
            }

            for (int i = 097; i < 123; i++)
            {
                Assert.AreEqual((char)i, linkedList.KthToLastDoublyLinked(122 - i));
            }
        }

        [TestMethod]
        public void SingleChar2()
        {
            LinkedList<char> linkedList = new LinkedList<char>();
            for (int i = 097; i < 123; i++)
            {
                linkedList.AddLast((char)i);
            }

            for (int i = 097; i < 123; i++)
            {
                Assert.AreEqual((char)i, linkedList.KthToLastSinglyLinked(122 - i));
            }
        }

        [TestMethod]
        public void SingleString1()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("test");
            Assert.AreEqual("test", linkedList.KthToLastSinglyLinked(0));
        }

        [TestMethod]
        public void DoubleString1()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("test");
            Assert.AreEqual("test", linkedList.KthToLastDoublyLinked(0));
        }

        [TestMethod]
        public void SingleString2()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            for (int i = 0; i <= 40; i++)
            {
                linkedList.AddLast(i.ToString());
            }

            for (int i = 0; i <= 40; i++)
            {
                Assert.AreEqual((40 - i).ToString(), linkedList.KthToLastSinglyLinked(i));
            }
        }

        [TestMethod]
        public void DoubleString2()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            for (int i = 0; i <= 40; i++)
            {
                linkedList.AddLast(i.ToString());
            }

            for (int i = 0; i <= 40; i++)
            {
                Assert.AreEqual((40 - i).ToString(), linkedList.KthToLastSinglyLinked(i));
            }
        }

    }
}
