using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analyzia.Database
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
