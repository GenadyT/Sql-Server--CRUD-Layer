using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDbCrud
{
    internal class DbEntryCartridge
    {
		private readonly string dbSubroutine;
		internal string DbSubroutine
        {
			get { return dbSubroutine; }
		}

        private readonly List<DbEntityFieldData> dbEntityFieldsData;
        internal List<DbEntityFieldData> DbEntityFieldsData
        {
            get { return dbEntityFieldsData; }
        }

        internal DbEntryCartridge(List<DbEntityFieldData> dbEntityFieldsData, string dbSubroutine)
		{
            this.dbEntityFieldsData = dbEntityFieldsData;
            this.dbSubroutine = dbSubroutine;
		}
    }
}
