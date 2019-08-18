using SQLite.Net;
using System.Collections.Generic;
using System.Linq;

namespace Analyzia.Database
{
    public class DatabaseHelper<TType> : IDatabaseHelper<TType> where TType : class
    {
        private static SQLiteConnection sqliteconnection;
        public DatabaseHelper()
        {
            sqliteconnection = SQLiteDBConnection.GetDatabaseConnection();
            sqliteconnection.CreateTable<TType>();
        }

        // Get All  data      
        public List<TType> GetAllData()
        {
            return (from data in sqliteconnection.Table<TType>()
                    select data).ToList();
        }

        //Get Specific data  
        ////public TType GetData(int id)
        ////{
        ////    return sqliteconnection.Table<TType>().FirstOrDefault(t => t.Id == id);
        ////}

        // Delete all s Data  
        public int DeleteAll()
        {
            return sqliteconnection.DeleteAll<TType>();
        }

        // Delete Specific   
        public int Delete(int id)
        {
            return sqliteconnection.Delete<TType>(id);
        }

        // Insert new  to DB   
        public int Insert(TType type)
        {
            return sqliteconnection.Insert(type);
        }

        // Update  Data  
        public int Update(TType type)
        {
            return sqliteconnection.Update(type);
        }
    }
}
