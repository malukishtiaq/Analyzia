using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analyzia.Models
{
    [Table("Habits")]
    public class Habits
    {
        [PrimaryKey, Unique, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
