using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    internal class Boletim
    {
        int id;
        Aluno aluno;
        List<Media> medias;
        public int Id { get => id; set => id = value; }
        public Aluno Aluno { get => aluno; set => aluno = value; }
        internal List<Media> Medias { get => medias; }
    }
}
