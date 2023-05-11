using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produto_interface
{
    public interface ICarrinho
    {
        // Regras de "contrato"
        // métodos que deverão aqui ser declarados apenas

        // CRUD : Create, Read, Update, Delete

        // padrão de chamada de método
        // tipo Nome(parametros)

        // Create
        void Adicionar(Produto _produto);

        // Read
        void Listar();

        // Update
        void Atualizar(int _codigo, Produto _produto);

        // Delete
        void Remover(Produto _produto);
    }
}