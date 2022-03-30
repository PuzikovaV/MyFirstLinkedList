using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class TheListIsEmptyWithIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            LList list = new LList(new int[] {});
            yield return new object[] { index, list };
        }
    }
}
