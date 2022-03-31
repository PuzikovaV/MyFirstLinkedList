using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class FindIndexOfMinValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LList list = new LList(new int[] {8,5,3,1,2,6});
            int expectedIndex = 3;
            yield return new object[] {list, expectedIndex};

            list = new LList(new int[] { 1,5,6,8 });
            expectedIndex = 0;
            yield return new object[] { list, expectedIndex };
        }
    }
}
