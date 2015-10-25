using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace CleanNotes
{
    public class Serializer
    {
    
        /**
         * Given a note object, 
         * it returns its JSON representation.
         */
        public static string Serialize(Note note)
        {
            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Note));

            ser.WriteObject(stream1, note);

            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);

            return sr.ReadToEnd();
        }

        /**
         * Given a JSON string,
         * it returns its object representation 
         */
        public static Note Deserialize(string json)
        {
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Note));
            return (Note)serializer.ReadObject(ms);
        }

    }
}
