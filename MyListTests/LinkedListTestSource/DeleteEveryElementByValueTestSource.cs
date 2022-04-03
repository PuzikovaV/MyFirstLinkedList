using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class DeleteEveryElementByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            LList list = new LList(new int[] {6,5,2,3,2,5,9});
            LList expectedList = new LList(new int[] {6,5,2,2,5,9});
            int expectedCount = 1;
            yield return new object[] {value, list, expectedList, expectedCount};

            value = 5;
            list = new LList(new int[] { 5,6,5,8,5 });
            expectedList = new LList(new int[] { 6,8 });
            expectedCount = 3;
            yield return new object[] { value, list, expectedList, expectedCount };

            value = 2;
            list = new LList(new int[] { 2,2,2,3 });
            expectedList = new LList(new int[] { 3 });
            expectedCount = 3;
            yield return new object[] { value, list, expectedList, expectedCount };
        }
    }
}
