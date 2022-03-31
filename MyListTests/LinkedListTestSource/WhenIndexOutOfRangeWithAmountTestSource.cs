using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class WhenIndexOutOfRangeWithAmountTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = -9;
            int amount = 2;
            LList list = new LList(new int[] {4,8,9});
            yield return new object[] {index, amount,list};

            index = 16;
            amount = 1;
            list = new LList(new int[] { 4, 8, 9 });
            yield return new object[] { index, amount, list };
        }
    }
}
