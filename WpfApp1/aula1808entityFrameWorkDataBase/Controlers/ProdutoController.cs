using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1808entityFrameWorkDataBase.Controlers
{
    class ProdutoController
    {
        void inser(Product produto)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            contexto.Product.Add(produto);
            contexto.SaveChanges();

        }

        List<Product> ListaProduto()
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.ToList();
        }

        Product BuscarPorId(int id)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.Find();

        }

        void Excluir(int id)
        {
            Product ExcluirPoduto = BuscarPorId(id);

            if(ExcluirPoduto != null)
            {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Product.Remove(ExcluirPoduto);
                contexto.SaveChanges();
            }
        }

        void Editar(int id, Product novoProduto)
        {
            Product produtoAntigo = BuscarPorId(id);

            if(produtoAntigo != null)
            {
                produtoAntigo.Color = novoProduto.Color;
                produtoAntigo.ListPrice = novoProduto.ListPrice;

                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Entry(produtoAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();

               
            }
        }

        List<Product> PesquisarProduto(string descricao)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();

            var lista = from lp in contexto.Product
                        where lp.Name == descricao
                        select lp;

            return lista.ToList();


        }

    }
}
