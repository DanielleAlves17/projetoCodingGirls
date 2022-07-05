using Microsoft.EntityFrameworkCore;
using Escola.Model;

namespace Escola.Context
{
    public class Escola_Context : DbContext
    {

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public Escola_Context(DbContextOptions<Escola_Context> options)
               : base(options)
            {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("aluno");
            modelBuilder.Entity<Aluno>()
           .HasOne(e => e.Turma)
           .WithMany(e => e.Alunos)
           .HasForeignKey(e => e.turmaId);


            modelBuilder.Entity<Turma>().ToTable("turma");
            //modelBuilder.Entity<Turma>()
            //    .HasMany(e => e.Alunos)
            //    .WithOne(e => e.Turma);
        }



    }
}
