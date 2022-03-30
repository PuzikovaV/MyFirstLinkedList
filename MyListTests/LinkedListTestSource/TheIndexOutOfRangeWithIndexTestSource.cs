using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class TheIndexOutOfRangeWithIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = -5;
            LList list = new LList(new int[] { 77, 5, 9, 8, 2 });
            yield return new object[] { index, list };

            index = 6;
            list = new LList(new int[] { 5, 8 });
            yield return new object[] { index, list };
        }
    }
}
