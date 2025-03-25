namespace DDDCommerceComRepository.Domain.RedeSocial.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Curso { get; set; }
        public List<Usuario> Seguidores { get; set; }

        public Usuario()
        {
            Seguidores = new List<Usuario>();
        }

        public void Seguir(Usuario usuario)
        {
            if (!Seguidores.Contains(usuario))
            {
                Seguidores.Add(usuario);
            }
        }

        public void DeixarDeSeguir(Usuario usuario)
        {
            Seguidores.Remove(usuario);
        }
    }
}
