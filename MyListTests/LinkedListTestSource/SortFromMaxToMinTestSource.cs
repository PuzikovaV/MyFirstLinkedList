using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class SortFromMaxToMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LList list = new LList(new int[] {99,8,102,3});
            LList expectedList = new LList(new int[] {102,99,8,3});
            yield return new object[] {list, expectedList};

            list = new LList(new int[] { 3, 10 });
            expectedList = new LList(new int[] { 10, 3 });
            yield return new object[] { list, expectedList };
        }
    }
}
