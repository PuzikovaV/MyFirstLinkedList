using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class FindMinValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LList list = new LList(new int[] { 8, 99, 8, 526, 3 });
            int expectedMinValue = 3;
            yield return new object[] { list, expectedMinValue };

            list = new LList(new int[] { 5 });
            expectedMinValue = 5;
            yield return new object[] { list, expectedMinValue };

            list = new LList(new int[] { 5, 0, 1, 0, 3});
            expectedMinValue = 0;
            yield return new object[] { list, expectedMinValue };
        }
    }
}
