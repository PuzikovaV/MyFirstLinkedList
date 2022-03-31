using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class SetByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            int value = 99;
            LList list = new LList(new int[] { 6, 5, 9, 88, 96 });
            LList expectedList = new LList(new int[] { 6, 5, 99, 88, 96 });
            yield return new object[] { index, value, list, expectedList };

            index = 0;
            value = 99;
            list = new LList(new int[] { 6, 5, 9, 88, 96 });
            expectedList = new LList(new int[] { 99, 5, 9, 88, 96 });
            yield return new object[] { index, value, list, expectedList };

        }
    }
}
