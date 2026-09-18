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

        [HttpGet]
       public List<Usuario> BuscarUsuarios()
        {
            return usuarioService.BuscarUsuarios();
        }
        

        [HttpGet("{id}")]
        public ActionResult<Usuario> BuscarUsuario(int id)
        {
            Usuario usuario = usuarioService.BuscarUsuario(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;            
        }



        [HttpPost]
        public Usuario CriarUsuario(Usuario usuario)
        {
            return usuarioService.CriarUsuario(usuario);
        }


        [HttpPut("{id}")]
        public ActionResult<Usuario> AtualizarUsuario(int id, Usuario usuarioAtualizado)
        {
            Usuario u = usuarioService.AtualizarUsuario(id, usuarioAtualizado);

            if(u == null)
            {
                return NotFound();
            }

            return u;
        }

    }
}