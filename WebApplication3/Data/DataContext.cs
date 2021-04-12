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
            var client = new MongoClient("mongodb://VarejistaLojaDB_001:uQJ72MA0rUTVcj6S@cluster0-shard-00-00.fuq97.mongodb.net:27017,cluster0-shard-00-01.fuq97.mongodb.net:27017,cluster0-shard-00-02.fuq97.mongodb.net:27017/myFirstDatabase?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin&retryWrites=true&w=majority");
            database = client.GetDatabase("VarejistaLojaDB_001");

            return database;
        }

        public void CloseDb()
        {
            database = null;
        }
      
    }
}
