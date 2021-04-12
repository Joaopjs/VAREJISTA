using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3.Data
{
    public class Produto_DB : DataContext
    {
        /// <summary>
        /// Seleciona todos os dados do banco de dados
        /// </summary>
        /// <returns></returns>
        public List<Produto> GetProdutos()
        {            
            var db = OpenDb(); //abre o banco de dados

            tableProd = db.GetCollection<Produto>("Produto");

            var query = tableProd.AsQueryable<Produto>().Select(x => new Produto { IdCategoria = x.IdCategoria, NomeProduto = x.NomeProduto, Preco = x.Preco, Descricao = x.Descricao }).ToList();

            //fecha o banco de dados
            CloseDb();

            return query;
        }

        /// <summary>
        /// Insere dados na tabela Produto
        /// </summary>
        public void InsertProduto()
        {
            var db = OpenDb();

            tableProd = null;
            tableProd = db.GetCollection<Produto>("Produto");

            var Produto = new Produto { IdCategoria = 2, NomeProduto = "Televisor", Preco = 100, Descricao = "47 Polegadas" };

            tableProd.InsertOneAsync(Produto);

            CloseDb();
        }

        /// <summary>
        /// Atualizar Informações da tabela 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task UpdateProdutoAsync(int id)
        {
            var db = OpenDb();

            tableProd = db.GetCollection<Produto>("Produto");

            var Produto = new Produto { IdCategoria = 3, NomeProduto = "Guarda-Roupas" };

            var filter = Builders<Produto>.Filter.Eq(s => s.IdCategoria, id);
            var result = await tableProd.ReplaceOneAsync(filter, Produto);

            CloseDb();
        }

        /// <summary>
        /// Deletar Dados 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteProduto(int id)
        {
            var db = OpenDb();

            tableProd = db.GetCollection<Produto>("Produto");

            var filter = Builders<Produto>.Filter.Eq(s => s.IdCategoria, id);
            var result = await tableProd.DeleteManyAsync(filter);

            CloseDb();
        }
    }
}
