using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanRepo
{
    public abstract class AbstractFileRepo<T, K> : AbstractRepo<T, K>
    {
        // path to file
        protected string PATH;

        protected AbstractFileRepo(string pathName)
        {
            this.PATH = pathName;
        }

        protected string GetPath()
        {
            return this.PATH;
        }
    }
}
