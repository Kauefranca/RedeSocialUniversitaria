using DDDCommerceComRepository.Domain.RedeSocial.Entidades;
using DDDCommerceComRepository.Infra.RedeSocial.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCommerceComRepository.Infra.RedeSocial.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SqlContext sqlContext;

        public UsuarioRepository()
        {
            sqlContext = new SqlContext();
        }

        private List<Usuario> usuarios = new List<Usuario>();

        public Usuario ObterPorId(int id)
        {
            return usuarios.FirstOrDefault(u => u.Id == id);
        }

        public List<Usuario> ObterTodos()
        {
            return usuarios;
        }

        public void Adicionar(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void Atualizar(Usuario usuario)
        {
            var usuarioExistente = usuarios.FirstOrDefault(u => u.Id == usuario.Id);
            if (usuarioExistente != null)
            {
                usuarios.Remove(usuarioExistente);
                usuarios.Add(usuario);
            }
        }

        public void Remover(int id)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                usuarios.Remove(usuario);
            }
        }

        public List<Usuario> ObterSeguidores(int idUsuario)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == idUsuario);
            if (usuario != null)
            {
                return usuario.Seguidores;
            }
            return new List<Usuario>();
        }
    }
}
