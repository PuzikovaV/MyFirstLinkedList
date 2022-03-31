using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class WhenAmountMoreOrLessThenLengthWithIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            int amount = 66;
            LList list = new LList(new int[] {1,8,9,20});
            yield return new object[] {index, amount,list};

            index = 2;
            amount = -9;
            list = new LList(new int[] { 1, 8, 9, 20 });
            yield return new object[] { index, amount, list };

        }
    }
}
