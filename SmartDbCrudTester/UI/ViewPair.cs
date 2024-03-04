using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDbCrudTester.UI
{
    internal static class ViewPairEnum
    {
        internal static string ValueMember
        {
            get { return "Value"; }
        }

        internal static string DisplayMember 
        {
            get { return "Title"; }
        }
    }

    internal class ViewPair
    {
        private string value;
        public string Value
        {
            get { return value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
        }

        public ViewPair(string value, string title)
        {
            this.value = value;
            this.title = title;
        }
    }
}
