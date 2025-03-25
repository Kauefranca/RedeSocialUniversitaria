using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCommerceComRepository.Domain.RedeSocial.Entidades
{
    public class Postagem
    {
        public int Id { get; set; }
        public Usuario Autor { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataHora { get; set; }
        public List<Usuario> Curtidas { get; set; }
        public List<string> Comentarios { get; set; }

        public Postagem()
        {
            Curtidas = new List<Usuario>();
            Comentarios = new List<string>();
        }

        public void Curtir(Usuario usuario)
        {
            if (!Curtidas.Contains(usuario))
            {
                Curtidas.Add(usuario);
            }
        }

        public void Descurtir(Usuario usuario)
        {
            Curtidas.Remove(usuario);
        }

        public void AdicionarComentario(string comentario)
        {
            Comentarios.Add(comentario);
        }
    }
}