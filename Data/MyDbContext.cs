using CRUD_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Aqui você especifica o caminho para o seu banco de dados SQLite
            optionsBuilder.UseSqlite("Data Source=app.db"); // Caminho para o banco de dados SQLite
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Se necessário, você pode adicionar configurações adicionais aqui
            // Por exemplo, configurar a relação entre Pessoa e Endereco
      
        }
    }

}
