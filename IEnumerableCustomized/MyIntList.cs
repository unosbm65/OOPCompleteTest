using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableCustomized
{
    public class MyIntList : IEnumerable
    {
        private int[] data = {1, 2, 3};

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        private class Enumerator : IEnumerator // Define an inner class
        {
            // for the enumerator.
            private MyIntList collection;
            private int currentIndex;
           
           

            public Enumerator(MyIntList collection)
            {
                this.collection = collection;
                currentIndex = -1;
            }

            public object Current
            {
                get
                {
                    int x = -1;
                    if (currentIndex == x)
                    throw new InvalidOperationException("Enumeration not started!");
                    if (currentIndex == collection.data.Length)
                        throw new InvalidOperationException("Past end of list!");
                    return collection.data[currentIndex];
                }
            }

            public bool MoveNext()
            {
                if (currentIndex >= collection.data.Length - 1) return false;
                return ++currentIndex < collection.data.Length;
            }

            public void Reset()
            {
                int x = -1;
                currentIndex =x;
            }
        }
    }
}