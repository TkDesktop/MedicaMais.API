using MedicaMais.API.Modelos;

namespace MedicaMais.API.services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>();
        
        public Usuario BuscarUsuario(int id)
        {
            return usuarios.FirstOrDefault(u => u.usuarioId == id);
        }

        public Usuario CriarUsuario(Usuario u)
        {
            usuarios.Add(u);

            return u;
        }
    }
}
