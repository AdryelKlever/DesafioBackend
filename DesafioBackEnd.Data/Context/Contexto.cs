using DesafioBackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioBackEnd.Data.Context
{
    public class Contexto : DbContext
    {
        public Contexto()
        { }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }

        public DbSet<Medico> Medico { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Remover a propriedade de restrição-validação de exclusão em cascata
            foreach (var relacionamento in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relacionamento.DeleteBehavior = DeleteBehavior.Restrict;
            }

            //modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.ForSqlServerUseIdentityColumns();

            modelBuilder.Entity<Medico>(e => 
            {
                e.ToTable("Medico");
                e.HasKey(m => m.IdMedico).HasName("IdMedico");
                e.Property(m => m.IdMedico).HasColumnName("IdMedico")
                    .ValueGeneratedOnAdd();

                e.Property(m => m.IdEspecialidade).HasColumnName("IdEspecialidade")
                    .IsRequired();

                e.Property(m => m.NomeMedico).HasColumnName("NomeMedico")
                    .IsRequired()
                    .HasMaxLength(150);

                e.Property(m => m.CPF).HasColumnName("CPF")
                    .IsRequired()
                    .HasMaxLength(14);

                e.Property(m => m.CRM).HasColumnName("CRM")
                    .IsRequired();

            });

            modelBuilder.Entity<Especialidade>(e =>
            {
                e.ToTable("Especialidade");
                e.HasKey(es => es.IdEspecilidade).HasName("IdEspecialidade");
                e.Property(es => es.IdEspecilidade).HasColumnName("IdEspecialidade")
                    .ValueGeneratedOnAdd();

                e.Property(es => es.NomeEspecialidade).HasColumnName("NomeEspecialidade")
                    .IsRequired()
                    .HasMaxLength(150);

                e.HasMany(m => m.Medicos)
                    .WithOne(es => es.Especialidade)
                    .HasForeignKey(es => es.IdEspecialidade)
                    .HasConstraintName("FK_EspecialidadeMedico");

            });

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-8EOADS8; Initial Catalog=DesafioBackend; Integrated Security=False; User=sa; Password=1234");
        }
    }
}
