using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class FindIndexOfMaxValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LList list = new LList(new int[] {45,88,156,2,1});
            int expectedIndex = 2;
            yield return new object[] {list, expectedIndex};
            
            list = new LList(new int[] {1,1,2,2,1});
            expectedIndex = 2;
            yield return new object[] {list, expectedIndex};
        }
    }
}
