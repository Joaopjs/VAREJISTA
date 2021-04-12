using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3.Data
{
    public class Categoria_DB : DataContext
    {
        /// <summary>
        /// Seleciona todos os dados do banco de dados
        /// </summary>
        /// <returns></returns>
        public List<Categoria> GetCategorias()
        {
            var db = OpenDb();

            tableCat = db.GetCollection<Categoria>("Categoria");

            var query = tableCat.AsQueryable<Categoria>().Select(x => new Categoria { IdCategoria = x.IdCategoria, Titulo = x.Titulo }).ToList();

            CloseDb();

            return query;
        }

        /// <summary>
        /// Insere dados na tabela Categoria
        /// </summary>
        public void InsertCategoria()
        {
            var db = OpenDb();

            tableCat = null;
            tableCat = db.GetCollection<Categoria>("Categoria");

            var Categoria = new Categoria { IdCategoria = 2, Titulo = "Moveis" };

            tableCat.InsertOneAsync(Categoria);

            CloseDb();
        }

        /// <summary>
        /// Atualizar Informações da tabela 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task UpdateCategoriaAsync(int id)
        {
            var db = OpenDb();

            tableCat = db.GetCollection<Categoria>("Categoria");

            var Categoria = new Categoria { IdCategoria = 3, Titulo = "Moveiss" };

            var filter = Builders<Categoria>.Filter.Eq(s => s.IdCategoria, id);
            var result = await tableCat.ReplaceOneAsync(filter, Categoria);

            CloseDb();
        }

        /// <summary>
        /// Deletar Dados 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteCategoria(int id)
        {
            var db = OpenDb();

            tableCat = db.GetCollection<Categoria>("Categoria");

            var filter = Builders<Categoria>.Filter.Eq(s => s.IdCategoria, id);
            var result = await tableCat.DeleteManyAsync(filter);

            CloseDb();
        }

    }
}
