using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back
{
    public interface IDataBase
    {
       

        void ExecuteCommand(string query, Dictionary<string, object> args);
        List<Dictionary<string, object>> ExecuteReader(string query, Dictionary<string, object> args);

        object ExecuteScalar(string query, Dictionary<string, object> args);
        void ExecuteCommand(string querry);
        object ExecuteScalar(string querry);
        List<Dictionary<string, object>> ExecuteReader(string query);
    }
}
