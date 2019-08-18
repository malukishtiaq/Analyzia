using System.Collections.Generic;

namespace Analyzia.Database
{
    public interface IDatabaseHelper<TType> where TType : class
    {
        int Delete(int id);
        int DeleteAll();
        List<TType> GetAllData();
        int Insert(TType type);
        int Update(TType type);
    }
}