namespace SmartDbCrud
{
    public abstract class DbEntityManager
    {
        protected const int ZeroID = 0;
        protected const int ZeroInt = 0;
        protected const string ZeroString = "";
        
        private DataAPI dataLayer;

        protected readonly string dbInsertSubroutine;
        public string DbInsertSubroutine
        {
            get { return dbInsertSubroutine; }
        }        

        protected readonly string dbSelectSubroutine;
        public string DbSelectSubroutine
        {
            get { return dbSelectSubroutine; }
        }

        protected readonly string dbUpdateSubroutine;
        public string DbUpdateSubroutine
        {
            get { return dbUpdateSubroutine; }
        }

        protected readonly string dbDeleteSubroutine;
        public string DbDeleteSubroutine
        {
            get { return dbDeleteSubroutine; }
        }

        public DbEntityManager(string dbInsertSubroutine, string dbSelectSubroutine, 
            string dbUpdateSubroutine,  string dbDeleteSubroutine, string connectionString)
        {
            this.dbInsertSubroutine = dbInsertSubroutine;            
            this.dbSelectSubroutine = dbSelectSubroutine;
            this.dbUpdateSubroutine = dbUpdateSubroutine;
            this.dbDeleteSubroutine = dbDeleteSubroutine;
            //this.connectionString = connectionString;
            dataLayer = new DataAPI(connectionString);
        }

        internal DbEntryCartridge GetDbEntryCartridge(CRUD crud)
        {
            string entrySubroutine;

            switch (crud)
            {
                case CRUD.Insert :
                   entrySubroutine = dbInsertSubroutine;
                   break;
                case CRUD.Select:
                    entrySubroutine = dbSelectSubroutine;
                    break;
                case CRUD.Update:
                    entrySubroutine = dbUpdateSubroutine;
                    break;
                case CRUD.Delete:
                    entrySubroutine = dbDeleteSubroutine;
                    break;
                default:
                    entrySubroutine = dbSelectSubroutine;
                    break;
            }

            return new DbEntryCartridge(GetDbEntityFieldsData(crud), entrySubroutine);
        }

        protected abstract List<DbEntityFieldData> GetDbEntityFieldsData(CRUD crud);

        public List<DbEntityRow> CommitQuery(CRUD query)
        {            
            DbEntryCartridge entryCartridge = GetDbEntryCartridge(query);
            List<DbEntityRow> rowList = dataLayer.CommitSubroutine(entryCartridge);
            return rowList;
        }
    }
}
