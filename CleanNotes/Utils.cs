using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNotes
{
    public class Utils
    {
        public static void ClearFile(string path)
        {
            System.IO.File.WriteAllText(path, string.Empty);
        }
    }
}
