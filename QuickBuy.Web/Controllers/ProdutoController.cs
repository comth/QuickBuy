using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contratos;
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
    }
}
