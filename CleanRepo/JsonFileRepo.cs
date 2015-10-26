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
        
        private CacheMap<List<Note>> cacheMap;

        public CacheMap<List<Note>> CacheMap { get { return cacheMap; } }

        public JsonFileRepo(string pathName)
            : base(pathName) 
        {
            cacheMap = new CacheMap<List<Note>>();
        }

        public override void Save(Note item)
        {
            handleId(item);

            string s = Serializer.Serialize(item);
            System.IO.File.AppendAllText(GetPath(), s + System.Environment.NewLine);
        }

        /**
         * Auto-increment feature
         */
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

        
        override public List<Note> GetAll()
        {
            DateTime lastWritten = GetLastTimeWritten(GetPath());
            List<Note> cached = cacheMap[lastWritten];
            if (cached != null)
            {
                return cached;
            }

            List<Note> list = new List<Note>();
            string[] all = System.IO.File.ReadAllLines(GetPath());
            foreach (string line in all)
            {
                //TODO fail deserialize case
                Note note = Serializer.Deserialize(line);
                list.Add(note);
            }
            DateTime writeTime = GetLastTimeWritten(GetPath());
            cacheMap.Add(writeTime, list);

            return list;
        }

        private DateTime GetLastTimeWritten(string path)
        {
            return System.IO.File.GetLastWriteTime(path);
        }
    }
}
