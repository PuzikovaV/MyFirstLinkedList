using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class WhenListIsEmptyWithValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 9;
            LList list = new LList(new int[] {});
            yield return new object[] { value, list };
        }
    }
}
