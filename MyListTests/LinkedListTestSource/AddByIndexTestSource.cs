using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
using System.Collections;

namespace LinkedListTest.LinkedListTestSource
{
    public class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 6;
            int index = 2;
            LList list = new LList(new int[] { 1, 2, 10, 16, 20 });
            LList expectedList = new LList(new int[] { 1, 2, 6, 10, 16, 20 });
            yield return new object[] { value, index, list, expectedList };

            value = 6;
            index = 0;
            list = new LList(new int[] { 1, 2, 10, 16, 20 });
            expectedList = new LList(new int[] { 6, 1, 2, 10, 16, 20 });
            yield return new object[] { value, index, list, expectedList };
        }
    }
}
