using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LList extraList = new LList(new int[] {11,22,33});
            int index = 2;
            LList list = new LList(new int[] { 55, 66, 99, 88 });
            LList expectedList = new LList(new int[] { 55, 66, 99, 11, 22, 33, 88 });
            yield return new object[] {extraList, index, list, expectedList};

            extraList = new LList(new int[] { 11, 22 });
            index = 0;
            list = new LList(new int[] { 5, 8 });
            expectedList = new LList(new int[] { 11,22, 5, 8 });
            yield return new object[] { extraList, index, list, expectedList };

            extraList = new LList(new int[] { 11, 22 });
            index = 1;
            list = new LList(new int[] { 5, 8 });
            expectedList = new LList(new int[] { 5, 8, 11, 22 });
            yield return new object[] { extraList, index, list, expectedList };
        }
    }
}
