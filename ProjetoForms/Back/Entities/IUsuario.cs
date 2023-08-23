using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public interface IUsuario
    {
        void Logar(Usuario usuario, string senha);
    }
}
