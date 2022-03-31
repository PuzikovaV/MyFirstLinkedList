using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class DeleteFirstByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            LList list = new LList(new int[] { 1, 5, 2, 3, 6 });
            LList expectedList = new LList(new int[] { 1, 2, 3, 6 });
            int expectedIndex = 1;
            yield return new object[] { value, list, expectedList, expectedIndex };

            value = 8;
            list = new LList(new int[] { 8 });
            expectedList = new LList(new int[] {  });
            expectedIndex = 0;
            yield return new object[] { value, list, expectedList, expectedIndex };
        }
    }
}
