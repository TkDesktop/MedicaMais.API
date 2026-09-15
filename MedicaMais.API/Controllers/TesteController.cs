using MedicaMais.API.Modelos;
using Microsoft.AspNetCore.Mvc;


namespace MedicaMais.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteController : ControllerBase
    {
        [HttpGet]
        public List<Usuario> Testar()
        {
            return usuarios;
        }


        [HttpPost]
        public Usuario CriarUsuario(Usuario u)
        {
            usuarios.Add(u);
            return u;
            
        }

        private static List<Usuario> usuarios = new List<Usuario>();
        
            
        
    }
}
