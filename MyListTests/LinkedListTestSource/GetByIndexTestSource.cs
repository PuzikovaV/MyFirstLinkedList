using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class GetByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            LList list = new LList(new int[] { 1, 5, 8, 6, 88 });
            int expectedValue = 8;
            yield return new object[] {index, list, expectedValue };

            index = 0;
            list = new LList(new int[] { 1, 5, 8, 6, 88 });
            expectedValue = 1;
            yield return new object[] { index, list, expectedValue };
        }
    }
}
