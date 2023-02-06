using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ControleContas.Entity.Application;

namespace ControleContas.Repository.Context.Application
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcessoSistema> AcessoSistema { get; set; } = null!;
        public virtual DbSet<AcessoUsuario> AcessoUsuario { get; set; } = null!;
        public virtual DbSet<Email> Email { get; set; } = null!;
        public virtual DbSet<Municipios> Municipios { get; set; } = null!;
        public virtual DbSet<NumeroCelular> NumeroCelular { get; set; } = null!;
        public virtual DbSet<Usuario> Usuario { get; set; } = null!;
        public virtual DbSet<UsuarioSistema> UsuarioSistema { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcessoSistema>(entity =>
            {
                entity.HasKey(e => e.idAcessoSistema)
                    .HasName("PK__AcessoSi__7F2B35BA7F870887");

                entity.Property(e => e.dtAlteracao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.dtInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.nmUsuarioSGBD).HasDefaultValueSql("(user_name())");
            });

            modelBuilder.Entity<AcessoUsuario>(entity =>
            {
                entity.HasKey(e => e.idAcessoUsuario)
                    .HasName("PK__AcessoUs__DC60B296E7B4386B");

                entity.Property(e => e.dtAlteracao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.dtInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.nmUsuarioSGBD).HasDefaultValueSql("(user_name())");

                entity.HasOne(d => d.idAcessoSistemaNavigation)
                    .WithMany(p => p.AcessoUsuario)
                    .HasForeignKey(d => d.idAcessoSistema)
                    .HasConstraintName("FK__AcessoUsu__idAce__4AB81AF0");

                entity.HasOne(d => d.idUsuarioNavigation)
                    .WithMany(p => p.AcessoUsuario)
                    .HasForeignKey(d => d.idUsuario)
                    .HasConstraintName("FK__AcessoUsu__idUsu__4BAC3F29");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasKey(e => e.idEmail)
                    .HasName("PK__Email__DF5377104C171CE3");

                entity.Property(e => e.dtAlteracao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.dtInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.nmUsuarioSGBD).HasDefaultValueSql("(user_name())");

                entity.HasOne(d => d.idUsuarioNavigation)
                    .WithMany(p => p.Email)
                    .HasForeignKey(d => d.idUsuario)
                    .HasConstraintName("FK__Email__idUsuario__571DF1D5");
            });

            modelBuilder.Entity<Municipios>(entity =>
            {
                entity.HasKey(e => e.idMunicipio)
                    .HasName("PK__Municipi__FD10E4006FE14E0D");

                entity.Property(e => e.dtAlteracao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.dtInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.nmUsuarioSGBD).HasDefaultValueSql("(user_name())");

                entity.Property(e => e.uf).IsFixedLength();
            });

            modelBuilder.Entity<NumeroCelular>(entity =>
            {
                entity.HasKey(e => e.idNumeroCelular)
                    .HasName("PK__NumeroCe__29CBF48612141B3A");

                entity.Property(e => e.dtAlteracao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.dtInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.nmUsuarioSGBD).HasDefaultValueSql("(user_name())");

                entity.HasOne(d => d.idUsuarioNavigation)
                    .WithMany(p => p.NumeroCelular)
                    .HasForeignKey(d => d.idUsuario)
                    .HasConstraintName("FK__NumeroCel__idUsu__5CD6CB2B");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.idUsuario)
                    .HasName("PK__Usuario__645723A6D3B13DE7");

                entity.Property(e => e.dtAlteracao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.dtInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.nmUsuarioSGBD).HasDefaultValueSql("(user_name())");

                entity.HasOne(d => d.idMunicipioNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.idMunicipio)
                    .HasConstraintName("FK__Usuario__idMunic__3F466844");
            });

            modelBuilder.Entity<UsuarioSistema>(entity =>
            {
                entity.HasKey(e => e.idUsuarioSistema)
                    .HasName("PK__UsuarioS__208FEA444D3F5219");

                entity.Property(e => e.dtAlteracao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.dtInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.nmUsuarioSGBD).HasDefaultValueSql("(user_name())");

                entity.HasOne(d => d.idUsuarioNavigation)
                    .WithMany(p => p.UsuarioSistema)
                    .HasForeignKey(d => d.idUsuario)
                    .HasConstraintName("FK__UsuarioSi__idUsu__5165187F");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
