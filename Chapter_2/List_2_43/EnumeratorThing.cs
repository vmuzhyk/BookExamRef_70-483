using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_43
{
    class EnumeratorThing : IEnumerator<int>, IEnumerable
    {
        int count;
        int limit;
        public int Current
        {
            get
            {
                return count;
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return count;
            }
        }
        public void Dispose()
        {
        }
        public bool MoveNext()
        {
            if (++count == limit)
                return false;
            else
                return true;
        }
        public void Reset()
        {
            count = 0;
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public EnumeratorThing(int limit)
        {
            count = 0;
            this.limit = limit;
        }
    }
}
