using DbTableCrud.Models.Album;
using DbTableCrud.Models.MusicGenre;
using DbTableCrud.Models.MusicMood;
using MSSqlDataLayer;
using System.Configuration;
using System.Xml.Linq;

namespace DbTableCrud
{
    public partial class frmForTests : Form
    {
        private string connectionString;
        //private DataAPI dataLayer;

        public frmForTests()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyMusicMoods"].ConnectionString;
            DataControlsInit();
        }

        private void DataControlsInit()
        {
            // --- Music Moods -----
            MusicMoodManager musicMoodManager = new MusicMoodManager(connectionString);
            List<DbEntityRow> rowList = musicMoodManager.CommitQuery(CRUD.Select);
            //lstMoods.Load(rowList);

        }

    }
}
