using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class SortFromMintoMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LList list = new LList(new int[] { 8, 6, 5, 99, 2, 1 });
            LList expectedList = new LList(new int[] { 1, 2, 5, 6, 8, 99 });
            yield return new object[] { list, expectedList };

            list = new LList(new int[] { 99, 5 });
            expectedList = new LList(new int[] { 5, 99 });
            yield return new object[] { list, expectedList };
        }
    }
}
