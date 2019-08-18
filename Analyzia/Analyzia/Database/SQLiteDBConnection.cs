using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Analyzia.Database
{
    public static class SQLiteDBConnection
    {
        private const string DbFileName = "AssessMyselfDB.db";
        public static SQLiteConnection GetDatabaseConnection()
        {
            return DependencyService.Get<ISQLite>().GetConnection();
        }

        public static string GetDbFileName()
        {
            return DbFileName;
        }
    }
}
