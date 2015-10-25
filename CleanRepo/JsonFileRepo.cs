using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanNotes;

namespace CleanRepo
{
    public class JsonFileRepo : AbstractFileRepo<Note, int>
    {
        public JsonFileRepo(string pathName)
            : base(pathName) {}

        public override void Save(Note item)
        {
            handleId(item);

            string s = Serializer.Serialize(item);
            System.IO.File.AppendAllText(GetPath(), s + System.Environment.NewLine);
        }

        private void handleId(Note item)
        {
            item.Id = Size() + 1;
        }

        public override Note FindByID(int id)
        {
            if (id > Size()) throw new RepoException();
            return GetAll()[id];
        }

        public override int Size()
        {
            return GetAll().Count;
        }

        //todo moveto generic.
        public List<Note> GetAll()
        {
            List<Note> list = new List<Note>();
            string[] all = System.IO.File.ReadAllLines(GetPath());
            foreach (string line in all)
            {
                //TODO fail deserialize case
                Note note = Serializer.Deserialize(line);
                list.Add(note);
            }
            return list;
        }
    }
}
