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
            int value = 2;
            LList list = new LList(new int[] {6,5,2,3,5,2,9});
            LList expectedList = new LList(new int[] {6,5,3,5,9});
            int expectedCount = 2;
            yield return new object[] {value, list, expectedList, expectedCount};
        }
    }
}
