using DDDCommerceComRepository.Domain.RedeSocial.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCommerceComRepository.Infra
{
    public class SqlContext : DbContext
    {

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RedeSocialDb01");
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<Evento> Eventos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração da tabela Usuario
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Seguidores)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioSeguidores",
                    j => j.HasOne<Usuario>().WithMany().HasForeignKey("SeguidorId"),
                    j => j.HasOne<Usuario>().WithMany().HasForeignKey("SeguidoId")
                );

            // Configuração da Postagem
            modelBuilder.Entity<Postagem>()
                .HasOne(p => p.Autor)
                .WithMany()
                .HasForeignKey(p => p.AutorId);

            // Configuração da relação Postagem-Curtidas (Muitos-para-Muitos)
            modelBuilder.Entity<Postagem>()
                .HasMany(p => p.Curtidas)  // Postagens têm várias curtidas (relacionamento com "Usuario")
                .WithMany(u => u.Curtidas) // Usuários podem curtir várias postagens
                .UsingEntity<Dictionary<string, object>>(
                    "PostagemCurtidas",
                    j => j
                        .HasOne<Usuario>()
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict), // **Remove o cascata na deleção do usuário**
                    j => j
                        .HasOne<Postagem>()
                        .WithMany()
                        .HasForeignKey("PostagemId")
                        .OnDelete(DeleteBehavior.Cascade) // **Deixa a deleção em cascata na postagem**
                );

            // Configuração da relação Evento-Participantes (Muitos-para-Muitos)
            modelBuilder.Entity<Evento>()
                .HasMany(e => e.Participantes)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "EventoParticipantes",
                    j => j.HasOne<Usuario>().WithMany().HasForeignKey("UsuarioId"),
                    j => j.HasOne<Evento>().WithMany().HasForeignKey("EventoId")
                );
        }
    }
}
