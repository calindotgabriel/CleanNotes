using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNotes
{
    public class CacheMap<T> : Dictionary<DateTime, T>
    {
        public T this[DateTime lastModified]
        {
            get 
            {
                try { 
                        T item = base[lastModified];
                        return item;
                    }
                catch (KeyNotFoundException e)
                {
                    return default(T); 
                }
            }
        }
    }
}
