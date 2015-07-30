using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableCustomized
{
    public class MyGenCollection : IEnumerable<int>
    {
        int[] data = { 1, 2, 3 };
        public IEnumerator<int> GetEnumerator()
        {
            foreach (int i in data)
                yield return i;
        }
        IEnumerator IEnumerable.GetEnumerator()     // Explicit implementation
        {                                           // keeps it hidden.
            return GetEnumerator();
        }
    }
}
