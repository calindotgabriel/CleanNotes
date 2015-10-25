using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanRepo
{
    public abstract class InMemoryRepo<T, K> : AbstractRepo<T, K>
    {
        public InMemoryRepo() { }

        protected object[] entities = new object[10];
        protected int count = 0;

        override public int Size() { return count; }
    }
}
