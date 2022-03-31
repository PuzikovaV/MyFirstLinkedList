using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class FindMaxValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LList list = new LList(new int[] { 5, 8, 9, 55, 6 });
            int expectedMaxValue = 55;
            yield return new object[] { list, expectedMaxValue};

            list = new LList(new int[] { 5, 99, 9, 99, 6 });
            expectedMaxValue = 55;
            yield return new object[] { list, expectedMaxValue };
        }
    }
}
