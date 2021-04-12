using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication3.Data;
using WebApplication3.Model;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private Categoria_DB db_cat = new Categoria_DB();

        [HttpGet]
        [Route("Lista")]
        public List<Categoria> Get()
        {
            try
            {
                return db_cat.GetCategorias();
            }
            catch (Exception)
            {

                return null;
            }
            
        }

        [HttpPost]
        [Route("InsertCategoria")]
        public void Post()
        {
            try
            {
                db_cat.InsertCategoria();
            }
            catch (Exception)
            {

                
            }
          

        }

        [HttpPut]
        [Route("updateCategoria")]
        public void Update([FromBody]int id)
        {
            try
            {
                _ = db_cat.UpdateCategoriaAsync(id);
            }
            catch (Exception)
            {

               
            }            

        }


        [HttpDelete]
        [Route("DeleteCategoria")]
        public void Delete(int ID)
        {
            try
            {
                _ = db_cat.DeleteCategoria(ID);
            }
            catch (Exception)
            {

                
            }
            

        }
    }
}
