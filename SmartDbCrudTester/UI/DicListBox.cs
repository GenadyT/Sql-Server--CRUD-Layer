using SmartDbCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartDbCrudTester.UI
{
    public partial class DicListBox : UserControl
    {
        public object? SelectedValue
        {
            get {
                ListBox listBox = (ListBox)this.Controls["listBox"];
                return listBox.SelectedValue; 
            }
            set {
                ListBox listBox = (ListBox)this.Controls["listBox"];
                listBox.SelectedValue = value; 
            }
        }

        public object? SelectedItem
        {
            get
            {
                ListBox listBox = (ListBox)this.Controls["listBox"];
                return listBox.SelectedItem;
            }
            set
            {
                ListBox listBox = (ListBox)this.Controls["listBox"];
                listBox.SelectedItem = value;
            }
        }

        public DicListBox(string valueMember, string displayMember)
        {
            InitializeComponent();
            SubInit(valueMember, displayMember);
        }

        public void Load(List<DbEntityRow> dataSource, string valueMember, string displayMember)
        {
            List<ViewPair> vpRows = new List<ViewPair>();

            foreach (var objRow in dataSource)
            {
                string value = objRow[valueMember].ToString();
                string title = objRow[displayMember].ToString();
                ViewPair viewPair = new ViewPair(value, title);
                vpRows.Add(viewPair);
            }

            listBox.DataSource = vpRows;
            listBox.ValueMember = ViewPairEnum.ValueMember;
            listBox.DisplayMember = ViewPairEnum.DisplayMember;
        }

        private void SubInit(string valueMember, string displayMember)
        {
            listBox.ValueMember = valueMember;
            listBox.DisplayMember = displayMember;  
        }
    }
}
