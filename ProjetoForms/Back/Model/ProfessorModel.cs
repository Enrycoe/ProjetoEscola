﻿using ProjetoForms.Back.DAO;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Model
{
    internal class ProfessorModel : IPessoaModel
    {
        ProfessorDAO dao = new ProfessorDAO();

        public void Atualizar(Pessoa pessoa, Pessoa pessoaAtualizada)
        {
            if (pessoaAtualizada.GetType() == typeof(Professor))
            {
                try
                {
                    pessoaAtualizada.Idade = pessoaAtualizada.CalcularIdade(pessoaAtualizada.DataNascimento);
                    dao.Atualizar(pessoa, pessoaAtualizada);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        public void Cadastrar(Pessoa professor)
        {
            if (professor.GetType() == typeof(Professor))
            {
                try
                {
                    professor.Idade = professor.CalcularIdade(professor.DataNascimento);
                    dao.Cadastrar(professor);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        public void Deletar(int id)
        {
            try
            {
                dao.Deletar(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Listar();
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable BuscarPorNome(string nome)
        {
            return dao.BuscarPorNome(nome);
        }

        internal Professor ReceberProfessorPorId(int id)
        {
            try
            {
                return dao.ReceberProfessorPorId(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
