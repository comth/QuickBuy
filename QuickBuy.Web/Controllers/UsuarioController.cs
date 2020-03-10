using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Web.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UsuarioController : Controller
    {
		private readonly IUsuarioRepositorio usuarioRepositorio;
		public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
		{
			this.usuarioRepositorio = usuarioRepositorio;
		}

		[HttpPost]
        public ActionResult Post()
        {
			try
			{
				return Ok();
			}
			catch (Exception e)
			{

				return BadRequest(e.ToString());
			}
        }

		[HttpGet]
		public ActionResult Get()
		{
			try
			{
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.ToString());
			}
		}

		[HttpPost("VerificarUsuario")]
		public ActionResult VerificarUsuario([FromBody] Usuario usuario)
		{
			try
			{
				var usuarioRetorno = usuarioRepositorio.Obter(usuario.Email,usuario.Senha);
				if(usuarioRetorno != null)
				{
					return Ok(usuarioRetorno);
				}
				return BadRequest("Usuario e/ou Senha inválido(s)");
			}
			catch (Exception e)
			{

				return BadRequest(e.ToString());
			}
		}
	}
}
