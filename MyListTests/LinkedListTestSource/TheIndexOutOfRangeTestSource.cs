using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class TheIndexOutOfRangeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 8;
            int index = -9;
            LList list = new LList(new int[] { 5, 2, 9, 7 });
            yield return new object[] {value, index, list};

            value = 5;
            index = 20;
            list = new LList(new int[] { 5, 2, 9, 7 });
            yield return new object[] { value, index, list };
        }
    }
}
