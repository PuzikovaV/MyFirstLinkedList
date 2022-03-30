using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class TheListIsEmptyTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            int index = 3;
            LList list = new LList(new int[] { });
            yield return new object[] { value, index, list };
        }
    }
}
