using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    internal class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            LList list = new LList(new int[] {1,4,8,6});
            LList expectedList = new LList(new int[] {1,4,6});
            yield return new object[] {index,list,expectedList};

            index = 3;
            list = new LList(new int[] { 1, 4, 8, 6 });
            expectedList = new LList(new int[] { 1, 4, 8 });
            yield return new object[] { index, list, expectedList };

            index = 0;
            list = new LList(new int[] { 1 });
            expectedList = new LList(new int[] { });
            yield return new object[] { index, list, expectedList };

        }
    }
}
