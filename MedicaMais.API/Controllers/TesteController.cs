using MedicaMais.API.Modelos;
using Microsoft.AspNetCore.Mvc;
using MedicaMais.API.services;

namespace MedicaMais.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService usuarioService;

        public UsuarioController()
        {
            usuarioService = new UsuarioService();
        }

        [HttpGet]
        public Usuario BuscarUsuario()
        {
            return usuarioService.BuscarUsuario();
        }

        [HttpPost]
        public Usuario CriarUsuario(Usuario usuario)
        {
            return usuarioService.CriarUsuario(usuario);
        }

    }
}