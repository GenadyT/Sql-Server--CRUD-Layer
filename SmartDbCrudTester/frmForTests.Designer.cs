using DbTableCrud.UI;

namespace DbTableCrud
{
    partial class frmForTests
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            lstMoods = new DicListBox("ID", "Name");
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(24, 25);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 4;
            label2.Text = "Music Moods";
            // 
            // lstMoods
            // 
            lstMoods.Font = new Font("Segoe UI", 9F);
            lstMoods.Location = new Point(24, 52);
            lstMoods.Name = "lstMoods";
            lstMoods.Size = new Size(150, 156);
            lstMoods.TabIndex = 5;
            // 
            // frmForTests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(lstMoods);
            Controls.Add(label2);
            Name = "frmForTests";
            Text = "Tests Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DicListBox lstMoods;
    }
}
