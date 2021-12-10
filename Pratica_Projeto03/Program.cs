
using Pratica_Projeto03.Entities;
using Pratica_Projeto03.Repositories;
using System;
using System.Collections.Generic;

namespace Projeto03
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando um objeto fornecedor utilizando 
            //o construtor com entrada de argumentos
            var fornecedor = new Fornecedor(Guid.NewGuid(),"Fornecedor Teste", "12345678908765");

            //inicializando a lista de produtos do fornecedor
            fornecedor.Produtos = new List<Produto>();

            //adicionando produtos na lista..
            fornecedor.Produtos.Add(new Produto(Guid.NewGuid(), "Notebook",2000, 10, new DateTime(2021, 07, 09)));
            fornecedor.Produtos.Add(new Produto(Guid.NewGuid(), "Mochila",500, 20, new DateTime(2021, 07, 10)));
            fornecedor.Produtos.Add(new Produto(Guid.NewGuid(), "Celular",1000, 15, new DateTime(2021, 07, 11)));

            try
            {
                var fornecedorRepositoryTXT = new FornecedorRepositoryTXT();
                var fornecedorRepositoryJSON = new FornecedorRepositoryJSON();

                Console.WriteLine("\nEXPORTANDO TXT:");
                fornecedorRepositoryTXT.Exportar(fornecedor);

                Console.WriteLine("\nEXPORTANDO JSON:");
                fornecedorRepositoryJSON.Exportar(fornecedor);

                Console.WriteLine("\nIMPORTANDO TXT:");
                fornecedorRepositoryTXT.Importar(fornecedor.IdFornecedor);

                Console.WriteLine("\nIMPORTANDO JSON:");
                fornecedorRepositoryJSON.Importar(fornecedor.IdFornecedor);

            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
