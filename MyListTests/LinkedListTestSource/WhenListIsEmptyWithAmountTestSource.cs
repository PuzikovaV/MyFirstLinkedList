using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class WhenListIsEmptyWithAmountTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int amount = 5;
            LList list = new LList(new int[] { });
            yield return new object[] { amount, list };
        }
    }
}
