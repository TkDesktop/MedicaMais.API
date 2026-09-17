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

        public UsuarioController(UsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpGet("{id}")]
        public Usuario BuscarUsuario(int id)
        {
            return usuarioService.BuscarUsuario(id);
        }

        [HttpPost]
        public Usuario CriarUsuario(Usuario usuario)
        {
            return usuarioService.CriarUsuario(usuario);
        }

    }
}