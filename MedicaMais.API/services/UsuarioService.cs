using MedicaMais.API.Modelos;

namespace MedicaMais.API.services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>();
        
        public Usuario BuscarUsuario()
        {
            Usuario usuario = new Usuario();

            return usuario;
        }

        public Usuario CriarUsuario(Usuario u)
        {
            usuarios.Add(u);

            return u;
        }
    }
}
