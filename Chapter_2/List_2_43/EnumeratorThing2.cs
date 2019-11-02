using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_43
{
    class EnumeratorThing2 : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i < 10; i++)
                yield return i;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private int limit;
        public EnumeratorThing2(int limit)
        {
            this.limit = limit;
        }
    }
}
