
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace GameProj.DB{
    internal class GameProjContext: DbContext
    {
        public DbSet<Company> Companies { get; set; }
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameProj;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

