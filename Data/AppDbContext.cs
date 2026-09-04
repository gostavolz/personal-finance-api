using Microsoft.EntityFrameworkCore;
using PersonalFinanceApi.Models;

namespace PersonalFinanceApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Mapeia a tabela de transações no banco de dados
        public DbSet<Transaction> Transactions { get; set; }
    }
}
