using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDbCrud
{
    public class IdNameClassTemplate
    {
        protected readonly int id;
        public int ID
        {
            get { return id; }
        }

        protected readonly string name;
        public string Name
        {
            get { return name; }
        }

        public IdNameClassTemplate(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
