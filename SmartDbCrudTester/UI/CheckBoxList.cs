using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartDbCrudTester.UI
{
    public partial class CheckBoxList : UserControl
    {
        public CheckBoxList()
        {
            InitializeComponent();
            SubInit();
        }

        private void SubInit()
        {
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Margin = new System.Windows.Forms.Padding(50);
        }

        public void Load(List<string> checkList)
        {
            Clear();

            foreach (var comboName in checkList)
            {
                ((CheckBox)this.Controls[comboName]).Checked = true;
            }
        }

        public void Build(List<CheckBoxEntry> entries)
        {
            int nextLeft = 10, nextTop = 4;
            int leftStep = 80; int topStep = 35;
            int rowCombosCount = -1;

            foreach (var entry in entries)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Name = entry.Name;
                checkBox.Text = entry.Name;
                checkBox.Checked = false; 
                checkBox.Tag = entry.Tag;

                if (rowCombosCount == 3)
                {
                    nextLeft = 10;
                    nextTop += topStep;
                    rowCombosCount = 0;
                }
                else
                {
                    rowCombosCount++;
                }

                checkBox.Width = 70;
                checkBox.Left = nextLeft;
                nextLeft += leftStep;
                checkBox.Top = nextTop;

                this.Controls.Add(checkBox);
            }
        }

        public void LoadChecks(Dictionary<string, bool> checkList)
        {
            foreach (var comboName in checkList.Keys)
            {
                CheckBox checkBox = (CheckBox)this.Controls.Find(comboName, false).First();
                checkBox.Checked = checkList[comboName];
            }
        }

        public List<CheckBoxEntry> GetChecks()
        {
            List<CheckBoxEntry> checkList = new List<CheckBoxEntry>();

            foreach (var control in this.Controls)
            {
                CheckBox checkBox = (CheckBox)control;
                checkList.Add(new CheckBoxEntry(checkBox.Name, checkBox.Checked, checkBox.Tag));
            }

            return checkList;
        }

        public void Clear() 
        {
            foreach (var control in this.Controls)
            {
                CheckBox checkBox = (CheckBox)control;
                checkBox.Checked = false;
            }
        }
    }
}
