using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDbCrud
{
    public class DbEntityFieldData
    {
        private readonly string fieldName;
        public string FieldName
        {
            get { return fieldName; }
        }

        private readonly Type fieldType;
        public Type FieldType
        {
            get { return fieldType; }
        }

        private readonly object fieldValue;
        public object FieldValue
        {
            get { return fieldValue; }
        }

        public DbEntityFieldData(string fieldName, Type fieldType, object fieldValue) {
            this.fieldName = fieldName;
            this.fieldType = fieldType;
            this.fieldValue = fieldValue;
        }
    }
}
