using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCommerceComRepository.Domain.RedeSocial
{

    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public bool RequerInscricao { get; set; }
        public List<Usuario> Inscritos { get; set; }

        public Evento()
        {
            Inscritos = new List<Usuario>();
        }

        public void Inscrever(Usuario usuario)
        {
            if (RequerInscricao && !Inscritos.Contains(usuario))
            {
                Inscritos.Add(usuario);
            }
        }

        public void CancelarInscricao(Usuario usuario)
        {
            Inscritos.Remove(usuario);
        }
    }
}
