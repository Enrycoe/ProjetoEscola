using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.DAO
{
    public class ProvaDAO
    {

        private IDataBase dataBase;

        public ProvaDAO(IDataBase dataBase)
        {
            this.dataBase = dataBase;
        }

        public List<Prova> BuscarProvaPorMateria(Prova prova)
        {
            try
            {
                string query = "SELECT * FROM provas WHERE fk_Materia_ID = @materia AND fk_Aluno_RA = @aluno";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@materia", prova.Materia.Id },
                    {"@aluno", prova.Aluno.Id}
                };


                return ListarProva(dataBase.ExecuteReader(query, parametros));
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Prova> ListarProva(List<Dictionary<string, object>> resposta)
        {
            try
            {
                List<Prova> provas = new List<Prova>();
                foreach (Dictionary<string, object> linha in resposta)
                {

                    int idAluno = Convert.ToInt32(linha["fk_Aluno_RA"]);
                    Aluno aluno = new Aluno(idAluno);
                    int idMateria = Convert.ToInt32(linha["fk_Materia_ID"]);
                    Materia materia = new Materia(idMateria);


                    double nota = Convert.ToDouble(linha["nota"]);
                    int id = Convert.ToInt32(linha["id"]);
                    string descricao = linha["descricao"].ToString();
                    Prova prova = new Prova(id, nota, descricao, materia, aluno);
                    prova.Media = new Media();
                    var VerificarSeFazParteOuNaoDeMedia = linha["fk_Media_ID"];
                    if (VerificarSeFazParteOuNaoDeMedia != null && VerificarSeFazParteOuNaoDeMedia != DBNull.Value)
                    {
                        prova.Media.Id = Convert.ToInt32(VerificarSeFazParteOuNaoDeMedia);
                    }
                    provas.Add(prova);
                }
                return provas;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CadastrarProva(Prova prova)
        {
            try
            {

                string query = "INSERT INTO provas (nota, descricao, fk_materia_ID, fk_Aluno_RA) VALUES (@nota, @descricao, @materia, @aluno)";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    { "@nota", prova.Nota},
                    {"@descricao", prova.Descricao },
                    {"@materia", prova.Materia.Id },
                    {"@aluno", prova.Aluno.Id}
                };
                dataBase.ExecuteCommand(query, parametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void DeletarProvaPorAluno(int id)
        {
            try
            {
                string query = "DELETE FROM provas WHERE fk_Aluno_RA = @RA";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    { "@RA", id },
                };
                dataBase.ExecuteCommand(query, parametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void DesignarProvaMedia(Prova prova)
        {
            try
            {

                string query = "UPDATE provas SET fk_media_ID = @media WHERE ID = @ID";
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    {"@ID", prova.Id},
                    {"@media", prova.Media.Id }
                };
                dataBase.ExecuteCommand(query, parametros);

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
