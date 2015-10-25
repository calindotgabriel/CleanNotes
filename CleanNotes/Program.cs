using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNotes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Note note = new Note("todo", "fii mai macanache");
            Console.WriteLine(note.Title);

        }
    }
}
