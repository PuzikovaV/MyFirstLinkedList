using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class WhenListIsEmptyWithAmountAndIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 5;
            int amount = 8;
            LList list = new LList(new int[] { });
            yield return new object[] { index, amount, list };
        }
    }
}
