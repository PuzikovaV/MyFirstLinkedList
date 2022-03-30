using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest.LinkedListTestSource
{
    public class WhenAmountMoreOrLessThenLengthTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int amount = 4;
            LList list = new LList(new int[] {4,5});
            yield return new object[] {amount,list};

            amount = -10;
            list=new LList(new int[] {4,5});
            yield return new object[]{amount,list};
        }
    }
}
