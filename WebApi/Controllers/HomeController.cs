using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebPage.Models;
using Newtonsoft.Json;
using System.Resources;
using System.Net;

namespace WebPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<Produto> list = new List<Produto>();

        private static string EnderecoApi = "http://localhost:54034/Produto/";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (EnderecoApi.Length < 35)
            {
                EnderecoApi = EnderecoApi + "lista";
            }
           
            
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = httpClient.GetAsync(EnderecoApi).GetAwaiter().GetResult();


            if (response.StatusCode == HttpStatusCode.OK)
            {
                var res = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (res.Length > 2)
                {
                    list = JsonConvert.DeserializeObject<List<Produto>>(res);
                    
                    return View(list);
                }
                else
                {
                    return View(list); 
                }

            }
            else
            {
                return View(list);
            }

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
