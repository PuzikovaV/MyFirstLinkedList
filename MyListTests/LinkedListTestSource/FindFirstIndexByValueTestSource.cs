using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class FindFirstIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            LList list = new LList(new int[] {1,6,9,5,8});
            int expectedIndex = 3;
            yield return new object[] {value,list, expectedIndex};

            value = 5;
            list = new LList(new int[] { 5 });
            expectedIndex = 0;
            yield return new object[] { value, list, expectedIndex };

            value = 10;
            list = new LList(new int[] { 5, 10, 10, 15, 10 });
            expectedIndex = 1;
            yield return new object[] { value, list, expectedIndex };

            value = 10;
            list = new LList(new int[] { 5, 15 });
            expectedIndex = -1;
            yield return new object[] { value, list, expectedIndex };
        }
    }
}
