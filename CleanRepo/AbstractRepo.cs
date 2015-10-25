using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanRepo
{
    public abstract class AbstractRepo<T, K>
    {
        public abstract void Save(T item);
        public abstract T FindByID(K id);
        public abstract int Size();
    }
}
