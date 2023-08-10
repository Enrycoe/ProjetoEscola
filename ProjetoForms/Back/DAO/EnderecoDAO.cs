using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.DAO
{
    internal class EnderecoDAO
    {

        Conection conn = new Conection();
        MySqlCommand cmd;
        public int ReceberIDEndereco(Aluno aluno)
        {
            conn.AbrirConexao();
            cmd = new MySqlCommand("SELECT ID FROM endereco WHERE Nome_Rua = @nome AND Numero_Casa = @numero", conn.conn);
            cmd.Parameters.AddWithValue("@nome", aluno.Endereco.NomeRua);
            cmd.Parameters.AddWithValue("@numero", aluno.Endereco.NumCasa);
            var result = cmd.ExecuteScalar();
            return Convert.ToInt32(result);
        }
    }
}
