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

        public List<Usuario> BuscarUsuarios()
        {
            return usuarios;
        }

        public Usuario CriarUsuario(Usuario u)
        {
            usuarios.Add(u);

            return u;
        }

        public Usuario AtualizarUsuario(int id, Usuario usuarioAtualizado)
        {
            Usuario u = usuarios.FirstOrDefault(u => u.usuarioId == id);

            if(u == null)
            {
                return null;
            }

            u.nome = usuarioAtualizado.nome;
            u.CPF = usuarioAtualizado.CPF;
            u.telefone = usuarioAtualizado.telefone;
            u.tipoUsuario = usuarioAtualizado.tipoUsuario;
            u.plano = usuarioAtualizado.plano;
            u.email = usuarioAtualizado.email;
            u.foto = usuarioAtualizado.foto;

            return u;
        }
    }
}
