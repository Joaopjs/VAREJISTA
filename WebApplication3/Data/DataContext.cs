using Microsoft.Extensions.Diagnostics.HealthChecks;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3.Data
{
    public class DataContext
    {
        public IMongoDatabase database;

        public IMongoCollection<Categoria> tableCat;
        public IMongoCollection<Produto> tableProd;

        public DataContext()
        {
       
        }

        public IMongoDatabase OpenDb()
        {
            var client = new MongoClient(Config.Configurar.StringConnection);
            database = client.GetDatabase(Config.Configurar.NomeTabela);

            return database;
        }

        public void CloseDb()
        {
            database = null;
        }
      
    }
}
