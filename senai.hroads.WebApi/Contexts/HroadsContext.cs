using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai.hroads.WebApi.Domains;

#nullable disable

namespace senai.hroads.WebApi.Contexts
{
    public partial class HroadsContext : DbContext
    {
        public HroadsContext()
        {
        }

        public HroadsContext(DbContextOptions<HroadsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClassHab> ClassHabs { get; set; }
        public virtual DbSet<Classe> Classes { get; set; }
        public virtual DbSet<Habilidade> Habilidades { get; set; }
        public virtual DbSet<Personagem> Personagems { get; set; }
        public virtual DbSet<TipoHabilidade> TipoHabilidades { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS; initial catalog=SENAI_HROADS_MANHA; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<ClassHab>(entity =>
            {
                entity.HasKey(e => e.IdClassHab)
                    .HasName("PK__classHab__7CA9105F0B71BF24");

                entity.ToTable("classHab");

                entity.Property(e => e.IdClassHab).HasColumnName("idClassHab");

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.IdHabilidade).HasColumnName("idHabilidade");

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.ClassHabs)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__classHab__idClas__300424B4");

                entity.HasOne(d => d.IdHabilidadeNavigation)
                    .WithMany(p => p.ClassHabs)
                    .HasForeignKey(d => d.IdHabilidade)
                    .HasConstraintName("FK__classHab__idHabi__30F848ED");
            });

            modelBuilder.Entity<Classe>(entity =>
            {
                entity.HasKey(e => e.IdClasse)
                    .HasName("PK__classe__60FFF801CBAD834A");

                entity.ToTable("classe");

                entity.HasIndex(e => e.NomeClasse, "UQ__classe__F1ED8102A4486425")
                    .IsUnique();

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.NomeClasse)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeClasse");
            });

            modelBuilder.Entity<Habilidade>(entity =>
            {
                entity.HasKey(e => e.IdHabilidade)
                    .HasName("PK__habilida__655F75282A99191D");

                entity.ToTable("habilidade");

                entity.HasIndex(e => e.NomeHab, "UQ__habilida__412C4466C7909DB7")
                    .IsUnique();

                entity.Property(e => e.IdHabilidade).HasColumnName("idHabilidade");

                entity.Property(e => e.IdTipoHab).HasColumnName("idTipoHab");

                entity.Property(e => e.NomeHab)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeHab");

                entity.HasOne(d => d.IdTipoHabNavigation)
                    .WithMany(p => p.Habilidades)
                    .HasForeignKey(d => d.IdTipoHab)
                    .HasConstraintName("FK__habilidad__idTip__2D27B809");
            });

            modelBuilder.Entity<Personagem>(entity =>
            {
                entity.HasKey(e => e.IdPersonagem)
                    .HasName("PK__personag__E175C72E87D7C663");

                entity.ToTable("personagem");

                entity.Property(e => e.IdPersonagem).HasColumnName("idPersonagem");

                entity.Property(e => e.CapMana).HasColumnName("capMana");

                entity.Property(e => e.CapVida).HasColumnName("capVida");

                entity.Property(e => e.DataAtt)
                    .HasColumnType("date")
                    .HasColumnName("dataAtt");

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("date")
                    .HasColumnName("dataCriacao");

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.Personagems)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__personage__idCla__276EDEB3");
            });

            modelBuilder.Entity<TipoHabilidade>(entity =>
            {
                entity.HasKey(e => e.IdTipoHab)
                    .HasName("PK__tipoHabi__FD3EC2541B35F12A");

                entity.ToTable("tipoHabilidade");

                entity.Property(e => e.IdTipoHab).HasColumnName("idTipoHab");

                entity.Property(e => e.NomeTipoHab)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("nomeTipoHab");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__tipoUsua__03006BFF7BB39566");

                entity.ToTable("tipoUsuario");

                entity.HasIndex(e => e.DescricaoTipoUsuario, "UQ__tipoUsua__C16C4DA1B204377A")
                    .IsUnique();

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.DescricaoTipoUsuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("descricaoTipoUsuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__usuario__645723A645A9DDA2");

                entity.ToTable("usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.EmailUsuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("emailUsuario");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.SenhaUsuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("senhaUsuario");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__usuario__idTipoU__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
