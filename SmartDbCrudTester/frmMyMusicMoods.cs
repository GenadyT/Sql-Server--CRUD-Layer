using SmartDbCrudTester.Models.Album;
using SmartDbCrudTester.Models.MusicGenre;
using SmartDbCrudTester.Models.MusicMood;
using SmartDbCrud;
using System.Configuration;
using System.Xml.Linq;
using SmartDbCrudTester.UI;
using System.Collections.Generic;

namespace DbTableCrud
{
    public partial class frmMyMusicMoods : Form
    {
        private string connectionString;
        //private DataAPI dataLayer;
        private int genreID;

        public frmMyMusicMoods()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyMusicMoods"].ConnectionString;
            DataControlsInit();
        }

        private void DataControlsInit()
        {
            LoadGenresList();
            LoadAllMoodsCombos();
        }

        private void LoadGenresList()
        {
            MusicGenreManager musicGenreManager = new MusicGenreManager(connectionString);
            List<DbEntityRow> rowList = musicGenreManager.CommitQuery(CRUD.Select);
            lstMusicGenres.Load(rowList, "ID", "Name");
            btnGetGenreAlbums.Enabled = (rowList.Count == 0) ? false : true;
        }

        private void btnGetGenreAlbums_Click(object sender, EventArgs e)
        {
            genreID = Convert.ToInt32(lstMusicGenres.SelectedValue);
            AlbumManager albumManager = new AlbumManager(genreID, connectionString);
            List<DbEntityRow> rowList = albumManager.CommitQuery(CRUD.Select);
            lstGenreAlbums.Load(rowList, "ID", "Name");
            btnViewAlbum.Enabled = (rowList.Count == 0) ? false : true;
        }

        private void LoadAllMoodsCombos()
        {
            MusicMoodManager musicMoodManager = new MusicMoodManager(connectionString);
            List<DbEntityRow> rowList = musicMoodManager.CommitQuery(CRUD.Select);
            chblAlbumMoods.Build(DbEntityRowsToCheckBoxEntries(rowList));
        }

        private void btnViewAlbum_Click(object sender, EventArgs e)
        {
            Control.ControlCollection pnlAlbumControls = pnlAlbumDetails.Controls;            

            int albumID = Convert.ToInt32(lstGenreAlbums.SelectedValue);
            tbxAlbumID.Text = albumID.ToString();

            AlbumManager albumManager = new AlbumManager(genreID, albumID, connectionString);
            DbEntityRow albumRow = albumManager.CommitQuery(CRUD.Select).First();

            pnlAlbumControls["tbxAlbumName"].Text = Utils.FieldValueToString(albumRow, "Name");
            pnlAlbumControls["tbxMyAlbumNotes"].Text = Utils.FieldValueToString(albumRow, "MyNotes");

            AlbumMoodsManager albumMoodsManager = new AlbumMoodsManager(albumID, connectionString);
            List<DbEntityRow> rowList = albumMoodsManager.CommitQuery(CRUD.Select);
            List<string> moodNames = Utils.EntityRowsToStringList(rowList, "Name");
            chblAlbumMoods.Load(moodNames);
        }

        private void btnAlbumUpdate_Click(object sender, EventArgs e)
        {
            int albumID = Convert.ToInt32(tbxAlbumID.Text);
            if (albumID <= 0) return;

            // --- Update Album ---
            Album album = new Album(albumID, tbxAlbumName.Text, tbxMyAlbumNotes.Text);
            AlbumManager albumManager = new AlbumManager(album, connectionString);
            albumManager.CommitQuery(CRUD.Update);

            // --- Update Album Moods ---
            List<int> albumMoods = chblAlbumMoods.GetChecks().
                Where(item => item.IsChecked).Select(item => Convert.ToInt32(item.Tag)).ToList();        
            AlbumMoodsManager albumMoodsManager = new AlbumMoodsManager(albumID, albumMoods, connectionString);
            albumMoodsManager.CommitQuery(CRUD.Update);
        }

        internal CheckBoxEntry DbEntityRowToCheckBoxEntry(DbEntityRow dbEntityRow)
        {
            return new CheckBoxEntry(Convert.ToString(dbEntityRow["Name"]), Convert.ToBoolean(dbEntityRow["IsChecked"]), dbEntityRow["ID"]);
        }

        internal List<CheckBoxEntry> DbEntityRowsToCheckBoxEntries(List<DbEntityRow> dbEntityRows)
        {
            List<CheckBoxEntry> checkBoxEntries = new List<CheckBoxEntry>();

            foreach (var entityRow in dbEntityRows)
            {
                checkBoxEntries.Add(DbEntityRowToCheckBoxEntry(entityRow));
            }

            return checkBoxEntries;
        }
    }
}
