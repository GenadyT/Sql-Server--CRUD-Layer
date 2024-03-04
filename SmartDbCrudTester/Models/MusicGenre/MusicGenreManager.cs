using SmartDbCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartDbCrudTester.Models.MusicGenre
{
    internal class MusicGenreManager : DbEntityManager
    {
        private MusicGenre musicGenre;
        public MusicGenre MusicGenre
        {
            get { return musicGenre; }
        }

        public MusicGenreManager(string connectionString) :
            base("spInsertMood", "spSelectGenres", "spUpdateGenres", "spDeleteGenres", connectionString)
        {
            musicGenre = new MusicGenre(ZeroID, ZeroString, ZeroString);
        }

        public MusicGenreManager(MusicGenre musicGenre, string connectionString) :
            base("spInsertMood", "spSelectMoods", "spUpdateMoods", "spDeleteMoods", connectionString)
        {
            this.musicGenre = musicGenre;
        }

        protected override List<DbEntityFieldData> GetDbEntityFieldsData(CRUD crud)
        {
            List<DbEntityFieldData> lst = new List<DbEntityFieldData>();

            lst.Add(new DbEntityFieldData("ID", musicGenre.ID.GetType(), musicGenre.ID));
            lst.Add(new DbEntityFieldData("Name", musicGenre.Name.GetType(), musicGenre.Name));

            return lst;
        }
    }
}
