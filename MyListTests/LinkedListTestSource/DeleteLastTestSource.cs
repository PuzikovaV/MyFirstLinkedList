using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LList list = new LList(new int[] { 78, 15, 16, 8 });
            LList expectedList = new LList(new int[] { 78, 15, 16 });
            yield return new object[] { list, expectedList };

            list = new LList (new int[] { 5, 4 });
            expectedList = new LList(new int[] { 5 });
            yield return new object[] { list, expectedList };
        }
    }
}
