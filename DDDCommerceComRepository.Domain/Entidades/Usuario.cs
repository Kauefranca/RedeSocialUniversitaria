namespace DDDCommerceComRepository.Domain.RedeSocial.Entidades
{
    public class Usuario
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Curso { get; private set; }

        public List<Usuario> Seguidores { get; private set; } = new();
        public List<Postagem> Curtidas { get; set; } // Lista de postagens que o usuário curtiu

        public Usuario(string nome, string email, string curso)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Curso = curso;
        }
    }
}
