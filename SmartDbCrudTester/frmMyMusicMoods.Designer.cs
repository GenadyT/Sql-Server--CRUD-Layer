using SmartDbCrudTester.UI;

namespace DbTableCrud
{
    partial class frmMyMusicMoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        private void InitializeComponent1()
        {
            panel1 = new Panel();
            btnViewAlbum = new Button();
            btnGetGenreAlbums = new Button();
            lstGenreAlbums = new DicListBox("ID", "Name");
            label1 = new Label();
            lstMusicGenres = new DicListBox("ID", "Name");
            label2 = new Label();
            pnlAlbumDetails = new Panel();
            chblAlbumMoods = new CheckBoxList();
            label5 = new Label();
            tbxMyAlbumNotes = new TextBox();
            label4 = new Label();
            tbxAlbumName = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            pnlAlbumDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnViewAlbum);
            panel1.Controls.Add(btnGetGenreAlbums);
            panel1.Controls.Add(lstGenreAlbums);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lstMusicGenres);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(22, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 275);
            panel1.TabIndex = 10;
            // 
            // btnViewAlbum
            // 
            btnViewAlbum.BackColor = Color.FromArgb(199, 199, 199);
            btnViewAlbum.Cursor = Cursors.Hand;
            btnViewAlbum.Enabled = false;
            btnViewAlbum.FlatAppearance.BorderColor = Color.DarkBlue;
            btnViewAlbum.FlatStyle = FlatStyle.Flat;
            btnViewAlbum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewAlbum.ForeColor = Color.DarkBlue;
            btnViewAlbum.Location = new Point(185, 225);
            btnViewAlbum.Name = "btnViewAlbum";
            btnViewAlbum.Size = new Size(208, 30);
            btnViewAlbum.TabIndex = 15;
            btnViewAlbum.Text = "view album details";
            btnViewAlbum.UseVisualStyleBackColor = false;
            btnViewAlbum.Click += btnViewAlbum_Click;
            // 
            // btnGetGenreAlbums
            // 
            btnGetGenreAlbums.BackColor = Color.FromArgb(199, 199, 199);
            btnGetGenreAlbums.Cursor = Cursors.Hand;
            btnGetGenreAlbums.Enabled = false;
            btnGetGenreAlbums.FlatAppearance.BorderColor = Color.DarkBlue;
            btnGetGenreAlbums.FlatStyle = FlatStyle.Flat;
            btnGetGenreAlbums.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGetGenreAlbums.ForeColor = Color.DarkBlue;
            btnGetGenreAlbums.Location = new Point(15, 225);
            btnGetGenreAlbums.Name = "btnGetGenreAlbums";
            btnGetGenreAlbums.Size = new Size(149, 30);
            btnGetGenreAlbums.TabIndex = 14;
            btnGetGenreAlbums.Text = "get genre albums";
            btnGetGenreAlbums.UseVisualStyleBackColor = false;
            btnGetGenreAlbums.Click += btnGetGenreAlbums_Click;
            // 
            // lstGenreAlbums
            // 
            lstGenreAlbums.Font = new Font("Segoe UI", 9F);
            lstGenreAlbums.Location = new Point(185, 42);
            lstGenreAlbums.Name = "lstGenreAlbums";
            lstGenreAlbums.SelectedValue = null;
            lstGenreAlbums.Size = new Size(208, 180);
            lstGenreAlbums.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(185, 15);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 12;
            label1.Text = "Genre Albums";
            // 
            // lstMusicGenres
            // 
            lstMusicGenres.Font = new Font("Segoe UI", 9F);
            lstMusicGenres.Location = new Point(15, 42);
            lstMusicGenres.Name = "lstMusicGenres";
            lstMusicGenres.SelectedValue = null;
            lstMusicGenres.Size = new Size(150, 180);
            lstMusicGenres.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 10;
            label2.Text = "Music Genres";
            // 
            // pnlAlbumDetails
            // 
            pnlAlbumDetails.BackColor = Color.Gainsboro;
            pnlAlbumDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlAlbumDetails.Controls.Add(chblAlbumMoods);
            pnlAlbumDetails.Controls.Add(label5);
            pnlAlbumDetails.Controls.Add(tbxMyAlbumNotes);
            pnlAlbumDetails.Controls.Add(label4);
            pnlAlbumDetails.Controls.Add(tbxAlbumName);
            pnlAlbumDetails.Controls.Add(label3);
            pnlAlbumDetails.Location = new Point(22, 318);
            pnlAlbumDetails.Name = "pnlAlbumDetails";
            pnlAlbumDetails.Size = new Size(412, 313);
            pnlAlbumDetails.TabIndex = 11;
            // 
            // chblAlbumMoods
            // 
            chblAlbumMoods.BorderStyle = BorderStyle.FixedSingle;
            chblAlbumMoods.Location = new Point(15, 80);
            chblAlbumMoods.Name = "chblAlbumMoods";
            chblAlbumMoods.Size = new Size(378, 102);
            chblAlbumMoods.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(15, 198);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 5;
            label5.Text = "My Album Notes";
            // 
            // tbxMyAlbumNotes
            // 
            tbxMyAlbumNotes.BackColor = SystemColors.Control;
            tbxMyAlbumNotes.Location = new Point(15, 226);
            tbxMyAlbumNotes.Multiline = true;
            tbxMyAlbumNotes.Name = "tbxMyAlbumNotes";
            tbxMyAlbumNotes.Size = new Size(378, 70);
            tbxMyAlbumNotes.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(15, 50);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 2;
            label4.Text = "My Album Moods";
            // 
            // tbxAlbumName
            // 
            tbxAlbumName.BackColor = SystemColors.Control;
            tbxAlbumName.Enabled = false;
            tbxAlbumName.Location = new Point(100, 13);
            tbxAlbumName.Name = "tbxAlbumName";
            tbxAlbumName.Size = new Size(293, 23);
            tbxAlbumName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(15, 16);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 0;
            label3.Text = "Album Name";
            // 
            // frmMyMusicMoods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 651);
            Controls.Add(pnlAlbumDetails);
            Controls.Add(panel1);
            Name = "frmMyMusicMoods";
            Text = "My Music Moods";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlAlbumDetails.ResumeLayout(false);
            pnlAlbumDetails.PerformLayout();
            ResumeLayout(false);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
btnViewAlbum = new Button();
btnGetGenreAlbums = new Button();
lstGenreAlbums = new DicListBox("ID", "Name");
label1 = new Label();
lstMusicGenres = new DicListBox("ID", "Name");
label2 = new Label();
pnlAlbumDetails = new Panel();
btnAlbumUpdate = new Button();
chblAlbumMoods = new CheckBoxList();
label5 = new Label();
tbxMyAlbumNotes = new TextBox();
label4 = new Label();
tbxAlbumName = new TextBox();
label3 = new Label();
tbxAlbumID = new TextBox();
panel1.SuspendLayout();
pnlAlbumDetails.SuspendLayout();
SuspendLayout();
// 
// panel1
// 
panel1.BackColor = Color.Gainsboro;
panel1.BorderStyle = BorderStyle.FixedSingle;
panel1.Controls.Add(btnViewAlbum);
panel1.Controls.Add(btnGetGenreAlbums);
panel1.Controls.Add(lstGenreAlbums);
panel1.Controls.Add(label1);
panel1.Controls.Add(lstMusicGenres);
panel1.Controls.Add(label2);
panel1.Location = new Point(22, 24);
panel1.Name = "panel1";
panel1.Size = new Size(412, 275);
panel1.TabIndex = 10;
// 
// btnViewAlbum
// 
btnViewAlbum.BackColor = Color.FromArgb(199, 199, 199);
btnViewAlbum.Cursor = Cursors.Hand;
btnViewAlbum.Enabled = false;
btnViewAlbum.FlatAppearance.BorderColor = Color.DarkBlue;
btnViewAlbum.FlatStyle = FlatStyle.Flat;
btnViewAlbum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
btnViewAlbum.ForeColor = Color.DarkBlue;
btnViewAlbum.Location = new Point(185, 225);
btnViewAlbum.Name = "btnViewAlbum";
btnViewAlbum.Size = new Size(208, 30);
btnViewAlbum.TabIndex = 15;
btnViewAlbum.Text = "view album details";
btnViewAlbum.UseVisualStyleBackColor = false;
btnViewAlbum.Click += btnViewAlbum_Click;
// 
// btnGetGenreAlbums
// 
btnGetGenreAlbums.BackColor = Color.FromArgb(199, 199, 199);
btnGetGenreAlbums.Cursor = Cursors.Hand;
btnGetGenreAlbums.Enabled = false;
btnGetGenreAlbums.FlatAppearance.BorderColor = Color.DarkBlue;
btnGetGenreAlbums.FlatStyle = FlatStyle.Flat;
btnGetGenreAlbums.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
btnGetGenreAlbums.ForeColor = Color.DarkBlue;
btnGetGenreAlbums.Location = new Point(15, 225);
btnGetGenreAlbums.Name = "btnGetGenreAlbums";
btnGetGenreAlbums.Size = new Size(149, 30);
btnGetGenreAlbums.TabIndex = 14;
btnGetGenreAlbums.Text = "get genre albums";
btnGetGenreAlbums.UseVisualStyleBackColor = false;
btnGetGenreAlbums.Click += btnGetGenreAlbums_Click;
// 
// lstGenreAlbums
// 
lstGenreAlbums.Font = new Font("Segoe UI", 9F);
lstGenreAlbums.Location = new Point(185, 42);
lstGenreAlbums.Name = "lstGenreAlbums";
lstGenreAlbums.SelectedItem = null;
lstGenreAlbums.SelectedValue = null;
lstGenreAlbums.Size = new Size(208, 180);
lstGenreAlbums.TabIndex = 13;
// 
// label1
// 
label1.AutoSize = true;
label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
label1.Location = new Point(185, 15);
label1.Name = "label1";
label1.Size = new Size(86, 15);
label1.TabIndex = 12;
label1.Text = "Genre Albums";
// 
// lstMusicGenres
// 
lstMusicGenres.Font = new Font("Segoe UI", 9F);
lstMusicGenres.Location = new Point(15, 42);
lstMusicGenres.Name = "lstMusicGenres";
lstMusicGenres.SelectedItem = null;
lstMusicGenres.SelectedValue = null;
lstMusicGenres.Size = new Size(150, 180);
lstMusicGenres.TabIndex = 11;
// 
// label2
// 
label2.AutoSize = true;
label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
label2.Location = new Point(15, 15);
label2.Name = "label2";
label2.Size = new Size(82, 15);
label2.TabIndex = 10;
label2.Text = "Music Genres";
// 
// pnlAlbumDetails
// 
pnlAlbumDetails.BackColor = Color.Gainsboro;
pnlAlbumDetails.BorderStyle = BorderStyle.FixedSingle;
pnlAlbumDetails.Controls.Add(tbxAlbumID);
pnlAlbumDetails.Controls.Add(btnAlbumUpdate);
pnlAlbumDetails.Controls.Add(chblAlbumMoods);
pnlAlbumDetails.Controls.Add(label5);
pnlAlbumDetails.Controls.Add(tbxMyAlbumNotes);
pnlAlbumDetails.Controls.Add(label4);
pnlAlbumDetails.Controls.Add(tbxAlbumName);
pnlAlbumDetails.Controls.Add(label3);
pnlAlbumDetails.Location = new Point(22, 318);
pnlAlbumDetails.Name = "pnlAlbumDetails";
pnlAlbumDetails.Size = new Size(412, 352);
pnlAlbumDetails.TabIndex = 11;
// 
// btnAlbumUpdate
// 
btnAlbumUpdate.BackColor = Color.FromArgb(139, 193, 217);
btnAlbumUpdate.FlatStyle = FlatStyle.Flat;
btnAlbumUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
btnAlbumUpdate.Location = new Point(15, 311);
btnAlbumUpdate.Name = "btnAlbumUpdate";
btnAlbumUpdate.Size = new Size(150, 27);
btnAlbumUpdate.TabIndex = 7;
btnAlbumUpdate.Text = "Album Update";
btnAlbumUpdate.UseVisualStyleBackColor = false;
btnAlbumUpdate.Click += btnAlbumUpdate_Click;
// 
// chblAlbumMoods
// 
chblAlbumMoods.AutoScroll = true;
chblAlbumMoods.BorderStyle = BorderStyle.FixedSingle;
chblAlbumMoods.Location = new Point(15, 80);
chblAlbumMoods.Margin = new Padding(50);
chblAlbumMoods.Name = "chblAlbumMoods";
chblAlbumMoods.Padding = new Padding(50);
chblAlbumMoods.Size = new Size(378, 102);
chblAlbumMoods.TabIndex = 6;
// 
// label5
// 
label5.AutoSize = true;
label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
label5.Location = new Point(15, 198);
label5.Name = "label5";
label5.Size = new Size(99, 15);
label5.TabIndex = 5;
label5.Text = "My Album Notes";
// 
// tbxMyAlbumNotes
// 
tbxMyAlbumNotes.BackColor = SystemColors.Control;
tbxMyAlbumNotes.Location = new Point(15, 226);
tbxMyAlbumNotes.Multiline = true;
tbxMyAlbumNotes.Name = "tbxMyAlbumNotes";
tbxMyAlbumNotes.Size = new Size(378, 70);
tbxMyAlbumNotes.TabIndex = 4;
// 
// label4
// 
label4.AutoSize = true;
label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
label4.Location = new Point(15, 50);
label4.Name = "label4";
label4.Size = new Size(103, 15);
label4.TabIndex = 2;
label4.Text = "My Album Moods";
// 
// tbxAlbumName
// 
tbxAlbumName.BackColor = SystemColors.Control;
tbxAlbumName.Enabled = false;
tbxAlbumName.Location = new Point(100, 13);
tbxAlbumName.Name = "tbxAlbumName";
tbxAlbumName.Size = new Size(293, 23);
tbxAlbumName.TabIndex = 1;
// 
// label3
// 
label3.AutoSize = true;
label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
label3.Location = new Point(15, 16);
label3.Name = "label3";
label3.Size = new Size(79, 15);
label3.TabIndex = 0;
label3.Text = "Album Name";
// 
// tbxAlbumID
// 
tbxAlbumID.Enabled = false;
tbxAlbumID.Location = new Point(375, 48);
tbxAlbumID.Name = "tbxAlbumID";
tbxAlbumID.Size = new Size(18, 23);
tbxAlbumID.TabIndex = 8;
tbxAlbumID.Text = "0";
tbxAlbumID.Visible = false;
// 
// frmMyMusicMoods
// 
AutoScaleDimensions = new SizeF(7F, 15F);
AutoScaleMode = AutoScaleMode.Font;
ClientSize = new Size(454, 695);
Controls.Add(pnlAlbumDetails);
Controls.Add(panel1);
Name = "frmMyMusicMoods";
Text = "My Music Moods";
panel1.ResumeLayout(false);
panel1.PerformLayout();
pnlAlbumDetails.ResumeLayout(false);
pnlAlbumDetails.PerformLayout();
ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DicListBox lstGenreAlbums;
        private Label label1;
        private DicListBox lstMusicGenres;
        private Label label2;
        private Button btnGetGenreAlbums;
        private Button btnViewAlbum;
        private Panel pnlAlbumDetails;
        private Label label3;
        private Label label4;
        private TextBox tbxAlbumName;
        private TextBox tbxMyAlbumNotes;
        private Label label5;
        private CheckBoxList chblAlbumMoods;
        private Button btnAlbumUpdate;
        private TextBox tbxAlbumID;
    }
}