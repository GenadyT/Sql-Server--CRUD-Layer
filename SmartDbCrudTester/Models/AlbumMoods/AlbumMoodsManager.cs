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
    internal class AlbumMoodsManager : DbEntityManager
    {   
        private int albumID;
        private string moods;

        public AlbumMoodsManager(string connectionString) :
            base("", "spSelectMoods", "spUpdateAlbumMoods", "", connectionString)
        {            
            this.albumID = ZeroID;
            this.moods = ZeroString;
        }

        public AlbumMoodsManager(int albumID, string connectionString) :
            base("", "spSelectMoods", "spUpdateAlbumMoods", "", connectionString)
        {
            //this.musicMood = new MusicMood(ZeroID, ZeroString, ZeroString);
            this.albumID = albumID;
            this.moods = ZeroString;
        }

        public AlbumMoodsManager(int albumID, List<int> moods, string connectionString) :
            base("", "spSelectMoods", "spUpdateAlbumMoods", "", connectionString)
        {
            //this.musicMood = new MusicMood(ZeroID, ZeroString, ZeroString);
            this.albumID = albumID;
            this.moods = Utils.ConvertIntArrayToString(moods.ToArray());
        }

        protected override List<DbEntityFieldData> GetDbEntityFieldsData(CRUD crud)
        {
            List<DbEntityFieldData> lst = new List<DbEntityFieldData>();

            lst.Add(new DbEntityFieldData("AlbumID", albumID.GetType(), albumID));

            if (crud == CRUD.Update)
            {
                lst.Add(new DbEntityFieldData("Moods", moods.GetType(), moods));
            }            

            return lst;
        }
    }
}
