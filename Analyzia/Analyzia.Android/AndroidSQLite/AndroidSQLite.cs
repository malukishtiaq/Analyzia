using Analyzia.Database;
using Analyzia.Droid.AndroidSQLite;
using SQLite.Net;
using System.IO;


[assembly: Xamarin.Forms.Dependency(typeof(AndroidSQLite))]
namespace Analyzia.Droid.AndroidSQLite
{
    public class AndroidSQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            var path = Path.Combine(documentsPath, SQLiteDBConnection.GetDbFileName());
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLiteConnection(plat, path);

            return conn;
        }
    }
}