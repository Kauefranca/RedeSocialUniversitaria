using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCommerceComRepository.Domain.RedeSocial.Entidades
{
    public class Postagem
    {
        public Guid Id { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataHora { get; set; }

        public Guid AutorId { get; set; }
        public Usuario Autor { get; set; }

        // Curtidas podem ser uma lista de Usuários sem relacionamento com cascata
        public List<Usuario> Curtidas { get; set; }
    }

}
