using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class AddFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            LList list = new LList(new int[] { 8, 9, 6 });
            LList expectedList = new LList(new int[] { 5, 8, 9, 6 });
            yield return new object[] { value, list, expectedList };

            value = 1;
            list = new LList(new int[] { 8 });
            expectedList = new LList(new int[] { 1, 8 });
            yield return new object[] { value, list, expectedList };

            value = 8;
            list = new LList(new int[] { });
            expectedList = new LList(new int[] { 8 });
            yield return new object[] { value, list, expectedList };
        }
    }
}
