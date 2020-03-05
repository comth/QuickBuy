using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBuy.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            this.produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(produtoRepositorio.ObterTodos());
                
            }
            catch (Exception e)
            {

                return BadRequest(e.ToString());
            }
        }

        public IActionResult Post([FromBody]Produto produto)
        {
            try
            {
                produtoRepositorio.Adicionar(produto);
                return Created("produto", produto);
            }
            catch (Exception e)
            {

                return BadRequest(e.ToString());
            }
        }
    }
}
