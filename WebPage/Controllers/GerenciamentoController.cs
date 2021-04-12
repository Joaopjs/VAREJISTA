using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using WebPage.Models;

namespace WebPage.Controllers
{
    public class GerenciamentoController : Controller
    {
        private static string EnderecoApi = "http://localhost:54034/Produto/";
        private readonly ILogger<HomeController> _logger;

        public GerenciamentoController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       
        public IActionResult Gerenciar(Produto produto)
        {
            HttpClient httpClient = new HttpClient();
            if (EnderecoApi.Length < 35)
            {
                EnderecoApi = EnderecoApi + "InsertProduto";
            }
            

            //StringContent param = new StringContent(string.Format("?id={0}", id));
            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("idcategoria", produto.IdCategoria.ToString()),
                new KeyValuePair<string, string>("nomeproduto", produto.NomeProduto),
                new KeyValuePair<string, string>("preco", produto.Preco.ToString()),
                new KeyValuePair<string, string>("descricao", produto.Descricao)
                });
            var response = httpClient.PostAsync(EnderecoApi, param).GetAwaiter().GetResult();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //Deserializar, retornar no metodo
                return View();
            }

            return View();
        }


        public IActionResult AddProduto(Produto produto)
        {
            

            return View(produto);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
