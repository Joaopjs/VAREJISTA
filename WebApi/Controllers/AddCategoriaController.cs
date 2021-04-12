using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage.Models;

namespace WebPage.Controllers
{
    public class AddCategoriaController : Controller
    {
        public IActionResult AdicionarCategoria(Categoria categoria)
        {
            return View(categoria);
        }
    }
}
