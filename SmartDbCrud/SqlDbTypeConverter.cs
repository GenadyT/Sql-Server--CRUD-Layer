using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDbCrud
{
    //https://stackoverflow.com/questions/35745226/net-system-type-to-sqldbtype

    /// <summary>
    /// This class inspired by the stackoverflow.com article - 
    /// https://stackoverflow.com/questions/35745226/net-system-type-to-sqldbtype
    /// </summary>
    internal class SqlDbTypeConverter
    {
        private static Dictionary<Type, SqlDbType> typeMap;

        static SqlDbTypeConverter()
        {
            typeMap = new Dictionary<Type, SqlDbType>();

            typeMap[typeof(string)] = SqlDbType.NVarChar;
            typeMap[typeof(char[])] = SqlDbType.NVarChar;
            typeMap[typeof(byte)] = SqlDbType.TinyInt;
            typeMap[typeof(short)] = SqlDbType.SmallInt;
            typeMap[typeof(int)] = SqlDbType.Int;
            typeMap[typeof(long)] = SqlDbType.BigInt;
            typeMap[typeof(byte[])] = SqlDbType.Image;
            typeMap[typeof(bool)] = SqlDbType.Bit;
            typeMap[typeof(DateTime)] = SqlDbType.DateTime2;
            typeMap[typeof(DateTimeOffset)] = SqlDbType.DateTimeOffset;
            typeMap[typeof(decimal)] = SqlDbType.Money;
            typeMap[typeof(float)] = SqlDbType.Real;
            typeMap[typeof(double)] = SqlDbType.Float;
            typeMap[typeof(TimeSpan)] = SqlDbType.Time;
            /* ... and so on ... */
        }

        internal static SqlDbType ConvertToSqlDbType(Type csharpType)
        {
            // Allow nullable types to be handled
            csharpType = Nullable.GetUnderlyingType(csharpType) ?? csharpType;

            if (typeMap.ContainsKey(csharpType))
            {
                return typeMap[csharpType];
            }

            throw new ArgumentException($"{csharpType.FullName} is not a supported .NET class");
        }
    }
}
