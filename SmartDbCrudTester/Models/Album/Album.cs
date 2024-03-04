using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartDbCrud;

namespace SmartDbCrudTester.Models.Album
{
    public class Album : IdNameClassTemplate
    {
        private readonly string myNotes;
        internal string MyNotes
        {
            get { return myNotes; }
        }

        internal Album(int id, string name, string myNotes) : base(id, name)
        {
            this.myNotes = myNotes;
        }
    }
}
