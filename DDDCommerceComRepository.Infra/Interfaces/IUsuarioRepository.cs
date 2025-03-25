using DDDCommerceComRepository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCommerceComRepository.Infra.RedeSocial.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario ObterPorId(int id);
        List<Usuario> ObterTodos();
        void Adicionar(Usuario usuario);
        void Atualizar(Usuario usuario);
        void Remover(int id);
        List<Usuario> ObterSeguidores(int idUsuario);

    }
}
