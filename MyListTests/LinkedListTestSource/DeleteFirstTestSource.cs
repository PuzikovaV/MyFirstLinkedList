using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class DeleteFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LList list = new LList(new int[] {4,5,9,8});
            LList expectedList = new LList(new int[] { 5, 9, 8 });
            yield return new object[] { list, expectedList };

            list = new LList(new int[] { 55, 99, 88});
            expectedList = new LList(new int[] { 99, 88 });
            yield return new object[] { list, expectedList };

            list = new LList(new int[] { 55 });
            expectedList = new LList(new int[] { });
            yield return new object[] { list, expectedList };
        }
    }
}
