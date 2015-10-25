﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CleanNotes
{
    [DataContract]
    public class Note
    {
        [DataMember]
        private int id;
        [DataMember]
        private string title;
        [DataMember]
        private string content;

        
        public Note() {}
        public Note(string title, string content)
        {
            this.title = title;
            this.content = content;
        }


        public int Id { get { return Id; } set { id = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string Content { get { return content; } set { content = value; } }
        
        
    }
}
