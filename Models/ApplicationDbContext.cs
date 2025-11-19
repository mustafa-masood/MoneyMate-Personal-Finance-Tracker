
using Microsoft.EntityFrameworkCore;

namespace MoneyMate_Personal_Finance_Tracker.Models

{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        { }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
