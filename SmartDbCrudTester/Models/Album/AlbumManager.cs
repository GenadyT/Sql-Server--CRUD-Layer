using SmartDbCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartDbCrudTester.Models.Album
{
    internal class AlbumManager : DbEntityManager
    {
        private Album album;
        private int genreID;

        public AlbumManager(string connectionString) :
            base("spInsertAlbum", "spSelectAlbums", "spUpdateAlbums", "spDeleteAlbums", connectionString)
        {
            album = new Album(ZeroID, ZeroString, ZeroString);
            this.genreID = ZeroID;
        }

        public AlbumManager(int genreID, string connectionString) :
            base("spInsertAlbum", "spSelectAlbums", "spUpdateAlbums", "spDeleteAlbums", connectionString)
        {
            album = new Album(ZeroID, ZeroString, ZeroString);
            this.genreID = genreID;
        }

        public AlbumManager(int genreID, int albumID, string connectionString) :
            base("spInsertAlbum", "spSelectAlbums", "spUpdateAlbums", "spDeleteAlbums", connectionString)
        {
            album = new Album(albumID, ZeroString, ZeroString);
            this.genreID = genreID;
        }

        public AlbumManager(Album album, string connectionString) :
            base("spInsertAlbum", "spSelectAlbums", "spUpdateAlbums", "spDeleteAlbums", connectionString)
        {
            this.album = album;
        }

        protected override List<DbEntityFieldData> GetDbEntityFieldsData(CRUD crud)
        {
            List<DbEntityFieldData> lst = new List<DbEntityFieldData>();
            
            lst.Add(new DbEntityFieldData("ID", album.ID.GetType(), album.ID));
            lst.Add(new DbEntityFieldData("GenreID", genreID.GetType(), genreID));
            lst.Add(new DbEntityFieldData("Name", album.Name.GetType(), album.Name));
            lst.Add(new DbEntityFieldData("MyNotes", album.MyNotes.GetType(), album.MyNotes));

            return lst;
        }
    }
}
