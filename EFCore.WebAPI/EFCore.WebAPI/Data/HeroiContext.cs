using EFCore.WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebAPI.Data
{
    public class HeroiContext : DbContext //vai encapsular todas as entidades
    {
        //Boa pratica do EF, deixar nomes de listas no plural
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }

        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }

        public DbSet<IdentidadeSecreta> IdentidadesSecretas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //faz a configuração do banco de dados
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;\r\nInitial Catalog=HeroApp;\r\nIntegrated Security=True;\r\n"); //string de conexão com o banco de dados
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity =>
            {
                entity.HasKey(e => new { e.BatalhaId, e.HeroId }); //chave composta
            });


        }
    }
}
