using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using ProjetoForms.Back.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms.Back.DAO
{
    public class ProfessorDAO
    {
        UsuarioDAO usuarioDAO;
        EnderecoDAO enderecoDAO;
        TurmaDAO turmaDAO;
        MateriaDAO materiaDAO;
        BairroDAO bairroDAO;
        IDataBase dataBase;

        public ProfessorDAO(IDataBase dataBase)
        {
            this.dataBase = dataBase;
            enderecoDAO = new EnderecoDAO(dataBase);
            turmaDAO = new TurmaDAO(dataBase);
            materiaDAO = new MateriaDAO(dataBase);
            bairroDAO = new BairroDAO(dataBase);
            usuarioDAO = new UsuarioDAO(dataBase);
        }
        public void Atualizar(Pessoa pessoa, Pessoa pessoaAtualizada)
        {

            Professor professor = pessoa as Professor;
            Professor professorAtualizada = pessoaAtualizada as Professor;
            try
            {


                bool bairroExiste = bairroDAO.VerificarSeBairroExiste(professorAtualizada.Endereco.Bairro);
                if (bairroExiste)
                {
                    professorAtualizada.Endereco.Bairro.Id = bairroDAO.ReceberIdBairro(professorAtualizada.Endereco.Bairro);
                    enderecoDAO.AtualizarEndereco(professorAtualizada.Endereco, professor.Endereco);
                }
                else
                {
                    bairroDAO.CadastrarBairro(professorAtualizada.Endereco.Bairro);
                    professorAtualizada.Endereco.Bairro.Id = bairroDAO.ReceberIdUltimoBairro();
                    enderecoDAO.AtualizarEndereco(professorAtualizada.Endereco, professor.Endereco);
                }
                DeletarMateriaDoProfessorPorId(professor.Id);
                DeletarTurmadoProfessorPorId(professor.Id);
                foreach (Materia materia in professorAtualizada.Materias)
                {
                    string queryMateria = "INSERT INTO materia_professor (fk_Materia_ID, fk_Professor_ID) VALUES (@materia, @professor)";
                    Dictionary<string, object> parametrosMateria = new Dictionary<string, object>()
                    {
                        {"@materia", materia.Id },
                        {"@professor", professorAtualizada.Id }
                    };
                    dataBase.ExecuteCommand(queryMateria, parametrosMateria);
                }
                foreach (Turma turma in professorAtualizada.Turmas)
                {
                    string queryTurma = "INSERT INTO professor_turma (fk_Turma_ID, fk_Professor_ID) VALUES (@turma, @professor)";
                    Dictionary<string, object> parametrosTurma = new Dictionary<string, object>()
                    {
                        {"@turma", turma.Id },
                        {"@professor", professorAtualizada.Id }
                    };
                    dataBase.ExecuteCommand(queryTurma, parametrosTurma);
                }
                string queryAtualizar = "UPDATE professor SET Data_de_Nascimento = @Data_de_Nascimento , Idade = @Idade, Nome = @nome, Telefone_Pessoal = @Telefone_Pessoal, Telefone_Fixo = @Telefone_Fixo WHERE ID = @ID";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                    {
                        {"@Data_de_Nascimento", professorAtualizada.DataNascimento.ToString("yyyy-MM-dd") },
                        {"@ID", professorAtualizada.Id},
                        {"@Idade", professorAtualizada.Idade },
                        {"@nome", professorAtualizada.Nome },
                        {"@Telefone_Pessoal", professorAtualizada.TelefonePessoal },
                        {"@Telefone_Fixo", professorAtualizada.TelefoneFixo }
                    };
                dataBase.ExecuteCommand(queryAtualizar, parametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Professor> BuscarPorNome(string nome)
        {
            try
            {

                string query = "SELECT * FROM professor WHERE Nome LIKE @nome";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@nome", nome + "%" }
                };

                List<Dictionary<string, object>> resultados = dataBase.ExecuteReader(query, parametros);

                return ListarProfessores(resultados);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Cadastrar(Pessoa pessoa, int idUsuario)
        {
            Professor professor = pessoa as Professor;
            try
            {
                bool bairroExiste = bairroDAO.VerificarSeBairroExiste(professor.Endereco.Bairro);
                if (bairroExiste)
                {
                    professor.Endereco.Bairro.Id = bairroDAO.ReceberIdBairro(professor.Endereco.Bairro);
                    enderecoDAO.CadastrarEndereco(professor.Endereco);
                    professor.Endereco.Id = enderecoDAO.ReceberIDUltimoEndereco();
                }
                else
                {
                    bairroDAO.CadastrarBairro(professor.Endereco.Bairro);
                    professor.Endereco.Bairro.Id = bairroDAO.ReceberIdUltimoBairro();
                    enderecoDAO.CadastrarEndereco(professor.Endereco);
                    professor.Endereco.Id = enderecoDAO.ReceberIDUltimoEndereco();

                }
                string query = "INSERT INTO professor (Idade, Data_de_Nascimento, fk_Endereço_ID,  Telefone_Pessoal, Telefone_Fixo, Nome, fk_Usuario_ID) " +
                        $"VALUES(@Idade, @Data_de_Nascimento, @fk_endereco_id, @Telefone_Pessoal, @Telefone_Fixo, @nome, @idUsuario)";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@Data_de_Nascimento", professor.DataNascimento.ToString("yyyy-MM-dd") },
                    {"@Idade", professor.Idade },
                    {"@nome", professor.Nome },
                    {"@fk_endereco_id", professor.Endereco.Id },
                    {"@Telefone_Pessoal", professor.TelefonePessoal },
                    {"@Telefone_Fixo", professor.TelefoneFixo },
                    {"@idUsuario", idUsuario }
                };
                dataBase.ExecuteCommand(query, parametros);
                professor.Id = ReceberIdUltimoProfessor();

                foreach (Materia materia in professor.Materias)
                {
                    string queryMateria = "INSERT INTO materia_professor(fk_Materia_ID, fk_Professor_ID) VALUES (@materia, @professor)";
                    Dictionary<string, object> parametrosMateria = new Dictionary<string, object>()
                    {
                        {"@materia", materia.Id },
                        {"@professor", professor.Id }
                    };
                    dataBase.ExecuteCommand(queryMateria, parametrosMateria);

                }

                foreach (Turma turma in professor.Turmas)
                {
                    string queryTurma = "INSERT INTO professor_turma(fk_Turma_ID, fk_Professor_ID) VALUES (@turma, @professor)";
                    Dictionary<string, object> parametrosTurma = new Dictionary<string, object>()
                    {
                        { "@turma", turma.Id},
                        {"@professor", professor.Id }
                    };
                    dataBase.ExecuteCommand(queryTurma, parametrosTurma);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int ReceberIdUltimoProfessor()
        {
            try
            {
                string query = "SELECT id FROM professor ORDER BY id DESC LIMIT 1";
                return Convert.ToInt32(dataBase.ExecuteScalar(query));
            }
            catch (Exception) 
            {

                throw;
            }
        }

        public void DeletarMateriaDoProfessorPorId(int id)
        {
            try
            {
               string query = "DELETE FROM materia_professor WHERE fk_Professor_ID = @ID";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ID", id }
                };
                dataBase.ExecuteCommand(query, parametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeletarTurmadoProfessorPorId(int id)
        {
            try
            {
                string query = "DELETE FROM professor_turma WHERE fk_Professor_ID = @ID";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ID", id }
                };
                dataBase.ExecuteCommand(query, parametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void DeletarPorId(int id)
        {
            try
            {
                
                DeletarMateriaDoProfessorPorId(id);
                DeletarTurmadoProfessorPorId(id);
                Professor professor = ReceberProfessorPorId(id);
                Usuario usuario = usuarioDAO.ReceberUsuarioPorProfessor(professor);
               string  query = "DELETE FROM professor WHERE ID = @ID";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ID", id }
                };
                dataBase.ExecuteCommand(query, parametros);
                usuarioDAO.DeletarLoginPorUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        public List<Professor> BuscarTodosProfessores()
        {
            try
            {
               string query = "SELECT * FROM professor";


                return ListarProfessores(dataBase.ExecuteReader(query));
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Professor> ListarProfessores(List<Dictionary<string, object>> resposta)
        {
            List<Professor> professores = new List<Professor>();

            foreach (Dictionary<string, object> linha in resposta)
            {
                int id = Convert.ToInt32(linha["ID"]);
                DateTime dataNascimento = Convert.ToDateTime(linha["Data_de_Nascimento"]);
                int idade = Convert.ToInt32(linha["Idade"]);
                string nome = linha["Nome"].ToString();
                string telefonePessoal = linha["Telefone_Pessoal"].ToString();
                string telefoneFixo = linha["Telefone_Fixo"].ToString();
                int idEndereco = Convert.ToInt32(linha["fk_endereço_id"]);
                Endereco endereco = enderecoDAO.ReceberEnderecoPorPessoa(idEndereco);
                List<Turma> turmas = turmaDAO.BuscarTurmasPorProfessor(id);
                List<Materia> materias = materiaDAO.BuscarMateriaPorProfessor(id);
                Professor professor = new Professor(id, nome, dataNascimento, idade, endereco, telefonePessoal, telefoneFixo, materias, turmas);
                professores.Add(professor);
            }
            return professores;
        }

        public Professor ReceberProfessorPorId(int id)
        {
            try
            {
               string query = "SELECT * FROM professor p WHERE p.ID = @ID";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ID", id }
                };
                
                var resposta = dataBase.ExecuteReader(query, parametros);
                foreach (Dictionary<string, object> linha in resposta)
                {

                    DateTime dataNascimento = Convert.ToDateTime(linha["Data_de_Nascimento"]);
                    int idade = Convert.ToInt32(linha["Idade"]);
                    string nome = linha["Nome"].ToString();
                    string telefonePessoal = linha["Telefone_Pessoal"].ToString();
                    string telefoneFixo = linha["Telefone_Fixo"].ToString();
                    int idEndereco = Convert.ToInt32(linha["fk_endereço_id"]);
                    Endereco endereco = enderecoDAO.ReceberEnderecoPorPessoa(idEndereco);
                    List<Turma> turmas = turmaDAO.BuscarTurmasPorProfessor(id);
                    List<Materia> materias = materiaDAO.BuscarMateriaPorProfessor(id);
                    Professor professor = new Professor(id, nome, dataNascimento, idade, endereco, telefonePessoal, telefoneFixo, materias, turmas);
                    return professor;
                }
                return null;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public Professor ReceberProfessorPorUsuarioID(int id)
        {
            try
            {

                string query = "SELECT * FROM professor p WHERE p.fk_Usuario_ID = @ID";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ID", id },
                };
                
                var resposta = dataBase.ExecuteReader(query, parametros);
                foreach (Dictionary<string, object> linha in resposta)
                {

                    DateTime dataNascimento = Convert.ToDateTime(linha["Data_de_Nascimento"]);
                    int idProfessor = Convert.ToInt32(linha["ID"]);
                    int idade = Convert.ToInt32(linha["Idade"]);
                    string nome = linha["Nome"].ToString();
                    string telefonePessoal = linha["Telefone_Pessoal"].ToString();
                    string telefoneFixo = linha["Telefone_Fixo"].ToString();
                    int idEndereco = Convert.ToInt32(linha["fk_endereço_id"]);
                    Endereco endereco = enderecoDAO.ReceberEnderecoPorPessoa(idEndereco);
                    List<Turma> turmas = turmaDAO.BuscarTurmasPorProfessor(id);
                    List<Materia> materias = materiaDAO.BuscarMateriaPorProfessor(id);
                    Professor professor = new Professor(idProfessor, nome, dataNascimento, idade, endereco, telefonePessoal, telefoneFixo, materias, turmas);
                    return professor;
                }
                return null;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

    }

}

