using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Config
{
    public static class Configurar
    {
        private static string Senha = "uQJ72MA0rUTVcj6S";
        public static string StringConnection = "mongodb://VarejistaLojaDB_001:"+Senha+"@cluster0-shard-00-00.fuq97.mongodb.net:27017,cluster0-shard-00-01.fuq97.mongodb.net:27017,cluster0-shard-00-02.fuq97.mongodb.net:27017/myFirstDatabase?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin&retryWrites=true&w=majority";
        public static string NomeTabela = "VarejistaLojaDB_001";
    }
}
