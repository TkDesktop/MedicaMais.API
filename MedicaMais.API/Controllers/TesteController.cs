
using MedicaMais.API.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace MedicaMais.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteController : ControllerBase
    {
        [HttpGet]
        public Usuario Testar()
        {
            Usuario u = new Usuario();

            u.usuarioId = 1;
            u.nome = "Calango";
            u.CPF = "123.456.789-00";

            return u;
        }

        [HttpPut("{id}")]
        public Usuario Atualizar(int id, Usuario usuario)
        {
            usuario.usuarioId = id;

            return usuario;
        }
    }
}

