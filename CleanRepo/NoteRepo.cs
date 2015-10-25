using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanNotes;

namespace CleanRepo
{
    public class NoteRepo : InMemoryRepo<Note, int>
    {
        public NoteRepo() { }

        override public void Save(Note note)
        {
            entities[count] = note;
            count++;
            note.Id = count;
        }

        override public Note FindByID(int id)
        {
            if (id > count) throw new RepoException();
            return (Note) entities[id];
        }

        
    }
}
