using SmartDbCrudTester.Models.Album;
using SmartDbCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartDbCrudTester.Models.MusicMood
{
    internal class MusicMoodManager : DbEntityManager
    {
        private MusicMood musicMood;
        private int albumID;

        public MusicMoodManager(string connectionString) :
            base("spInsertMood", "spSelectMoods", "spUpdateMoods", "spDeleteMoods", connectionString)
        {
            musicMood = new MusicMood(ZeroID, ZeroString, ZeroString);
            this.albumID = ZeroID;
        }

        public MusicMoodManager(int albumID, string connectionString) :
            base("spInsertMood", "spSelectMoods", "spUpdateMoods", "spDeleteMoods", connectionString)
        {
            this.musicMood = new MusicMood(ZeroID, ZeroString, ZeroString);
            this.albumID = albumID;
        }

        public MusicMoodManager(MusicMood musicMood, string connectionString) :
            base("spInsertMood", "spSelectMoods", "spUpdateMoods", "spDeleteMoods", connectionString)
        {
            this.musicMood = musicMood;
        }

        protected override List<DbEntityFieldData> GetDbEntityFieldsData(CRUD crud)
        {
            List<DbEntityFieldData> lst = new List<DbEntityFieldData>();

            lst.Add(new DbEntityFieldData("ID", musicMood.ID.GetType(), musicMood.ID));
            lst.Add(new DbEntityFieldData("AlbumID", albumID.GetType(), albumID));
            lst.Add(new DbEntityFieldData("Name", musicMood.Name.GetType(), musicMood.Name));
            lst.Add(new DbEntityFieldData("Comments", musicMood.Comments.GetType(), musicMood.Comments));

            return lst;
        }
    }
}
