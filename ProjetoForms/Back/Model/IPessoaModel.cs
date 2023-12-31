﻿using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Model
{
    public interface IPessoaModel
    {
        
        void Cadastrar(Pessoa pessoa);

        void AtualizarPorId (Pessoa pessoa, Pessoa pessoaAtualizada);

        List<T> Listar<T>() where T : Pessoa;

        void DeletarPorId(int id);
    }
}
