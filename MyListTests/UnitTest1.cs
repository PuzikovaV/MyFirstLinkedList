using NUnit.Framework;
using System.Collections;
using LinkedList;

namespace LinkedListTests
{
    public class Tests
    {
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(int value, LList list, LList expectedList)
        {
            list.Add(value);
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest (int value, LList list, LList expectedList)
        {
            list.AddFirst(value);
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int value, int index, LList list, LList expectedList)
        {
            list.AddByIndex(value, index);
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

    }

    public class AddLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            LList list = new LList(new int[]{ 8,9,6});
            LList expectedList = new LList(new int[]{ 8,9,6,5});
            yield return new object[] { value, list, expectedList };

            value = 1;
            list = new LList(new int[] { 8 });
            expectedList = new LList(new int[] { 8, 1 });
            yield return new object[] { value, list, expectedList };
            
            value = 8;
            list = new LList(new int[] { });
            expectedList = new LList(new int[] { 8 });
            yield return new object[] { value, list, expectedList };

        }
    }

    public class AddFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            LList list = new LList(new int[] { 8, 9, 6 });
            LList expectedList = new LList(new int[] { 5, 8, 9, 6 });
            yield return new object[] { value, list, expectedList };

            value = 1;
            list = new LList(new int[] { 8 });
            expectedList = new LList(new int[] { 1, 8 });
            yield return new object[] { value, list, expectedList };

            value = 8;
            list = new LList(new int[] { });
            expectedList = new LList(new int[] { 8 });
            yield return new object[] { value, list, expectedList };
        }
    }

    public class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 6;
            int index = 2;
            LList list = new LList(new int[] { 1, 2, 10, 16, 20 });
            LList expectedList = new LList(new int[] { 1, 2, 6, 10, 16, 20 });
            yield return new object[] {value, index, list, expectedList };
        }
    }
}