using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDbCrudTester.UI
{
    public class CheckBoxEntry
    {
		private string name;
		public string Name
        {
			get { return name; }
		}

        private bool isChecked;
        public bool IsChecked
        {
            get { return isChecked; }
        }

        private object tag;
        public object Tag
        {
            get { return tag; }
        }

        public CheckBoxEntry(string name, object tag)
        {
            this.name = name;
            this.isChecked = false;
            this.tag = tag;
        }

        public CheckBoxEntry(string name, bool isChecked, object tag)
        {
            this.name = name;
            this.isChecked = isChecked;
            this.tag = tag;
        }
    }
}
