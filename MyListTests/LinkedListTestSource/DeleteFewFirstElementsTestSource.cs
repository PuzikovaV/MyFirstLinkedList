using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class DeleteFewFirstElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int amount = 2;
            LList list = new LList(new int[] { 4, 8, 9, 6 });
            LList expectedList = new LList(new int[] { 9, 6 });
            yield return new object[] { amount, list, expectedList };

            amount = 4;
            list = new LList(new int[] { 4, 8, 9, 6 });
            expectedList = new LList(new int[] { });
            yield return new object[] { amount, list, expectedList };
            
            amount = 0;
            list = new LList(new int[] { 4, 8 });
            expectedList = new LList(new int[] { 4,8});
            yield return new object[] { amount, list, expectedList };
        }
    }
}
