namespace MedicaMais.API.Modelos
{
    public class Usuario
    {
        public int usuarioId {  get; set; }
        public string nome { get; set; }
        public string CPF { get; set; }
        public string telefone { get; set; }
        public TipoUsuario tipoUsuario { get; set; }
        public Plano plano { get; set; }
        public string email { get; set; }
        public string? foto { get; set; }
    }

}