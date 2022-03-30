using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class DeleteFewElementsByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            int amount = 2;
            LList list = new LList(new int[] { 4, 6, 9, 8, 32, 6 });
            LList expectedList = new LList(new int[] { 4, 6, 32, 6 });
            yield return new object[] { index, amount, list, expectedList };

            index = 1;
            amount = 5;
            list = new LList(new int[] { 4, 6, 9, 8, 32, 6 });
            expectedList = new LList(new int[] { 4 });
            yield return new object[] { index, amount, list, expectedList };

            index = 1;
            amount = 0;
            list = new LList(new int[] { 4, 6, 9, 8, 32, 6 });
            expectedList = new LList(new int[] { 4, 6, 9, 8, 32, 6 });
            yield return new object[] { index, amount, list, expectedList };
        }
    }
}
