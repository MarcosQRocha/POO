using Microsoft.EntityFrameworkCore;

namespace AS.Domain.Entities
{
    public class MeuContexto : DbContext
    {
        protected string DbPath { get; }
        public MeuContexto()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "Testando.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
   

        public DbSet<Person> Pessoas { get; set; }

    }

}
