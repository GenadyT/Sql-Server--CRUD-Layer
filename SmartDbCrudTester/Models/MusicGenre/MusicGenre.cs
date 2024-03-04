using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartDbCrud;

namespace SmartDbCrudTester.Models.MusicGenre
{
    internal class MusicGenre : IdNameClassTemplate
    {        
        private readonly string comments;
        internal string Comments
        {
            get { return comments; }
        }

        internal MusicGenre(int id, string name, string comments) : base(id, name)
        {   
            this.comments = comments;
        }
    }
}
