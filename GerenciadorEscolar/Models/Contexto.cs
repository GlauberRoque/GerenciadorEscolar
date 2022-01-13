using Microsoft.EntityFrameworkCore;

namespace GerenciadorEscolar.Models
{
    public class Contexto : DbContext
    {

        public Contexto( DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Professor> Professores { get; set; }
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost; initial Catalog=Gerenciador_Escolar;User ID = usuario; password = senha; language = Portuguese; Trusted_Connection = True");

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }

    }
}
