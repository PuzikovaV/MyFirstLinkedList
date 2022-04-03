using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class AddListInTheStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LList extraList = new LList(new int[] {45,5,6});
            LList list = new LList(new int[] {3,6,7});
            LList expectedList = new LList(new int[] { 45, 5, 6, 3, 6, 7 });
            yield return new object[] { extraList, list, expectedList };
        }
    }
}
