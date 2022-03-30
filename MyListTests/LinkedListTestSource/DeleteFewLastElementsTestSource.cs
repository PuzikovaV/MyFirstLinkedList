using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class DeleteFewLastElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int amount = 2;
            LList list = new LList(new int[] {4,6,8,9,7});
            LList expectedList = new LList(new int[] {4,6,8});
            yield return new object[] {amount,list,expectedList};

            amount = 3;
            list = new LList(new int[] { 4, 6, 8, 9, 7 });
            expectedList = new LList(new int[] { 4, 6 });
            yield return new object[] { amount, list, expectedList };

            amount = 0;
            list = new LList(new int[] { 4, 6 });
            expectedList = new LList(new int[] { 4, 6 });
            yield return new object[] { amount, list, expectedList };
        }
    }
}
