using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class AddListInTheEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LList list = new LList(new int[] {5,8,9});
            LList extraList = new LList(new int[] { 1, 3, 6 });
            LList expectedList = new LList(new int[] { 1, 3, 6, 5, 8, 9 });
            yield return new object[] { extraList, list, expectedList };
        }
    }
}
