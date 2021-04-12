using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data;
using WebApplication3.Model;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private Produto_DB db_Prod = new Produto_DB();

        [HttpPost]
        [Route("InsertProduto")]
        public void Post()
        {
            try
            {
                db_Prod.InsertProduto();
            }
            catch (Exception)
            {

                
            }
           

        }

        [HttpGet]
        [Route("Lista")]
        public List<Produto> Get()
        {
            try
            {
                return db_Prod.GetProdutos();
            }
            catch (Exception)
            {

                return null;
            }
            
        }

        [HttpPut]
        [Route("updateProduto")]
        public void Update()
        {
            try
            {
                _ = db_Prod.UpdateProdutoAsync(2);
            }
            catch (Exception)
            {

               
            }
            

        }


        [HttpDelete]
        [Route("DeleteProduto")]
        public void Delete(int id)
        {
            try
            {
                _ = db_Prod.DeleteProduto(id);
            }
            catch (Exception)
            {

               
            }
            

        }
    }
}
