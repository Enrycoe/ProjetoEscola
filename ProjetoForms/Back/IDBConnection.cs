using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back
{
    public interface IDBConnection
    {
        void AbrirConexao();

        void FecharConexao();
    }
}
