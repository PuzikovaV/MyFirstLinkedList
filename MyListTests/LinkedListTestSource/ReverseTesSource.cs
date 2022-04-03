using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LList list = new LList(new int[] { 5, 8, 9, 7 });
            LList expectedList = new LList(new int[] { 7, 9, 8, 5 });
            yield return new object[] { list, expectedList };
            
            list = new LList(new int[] { 88 });
            expectedList = new LList(new int[] { 88 });
            yield return new object[] { list, expectedList };
        }
    }
}
