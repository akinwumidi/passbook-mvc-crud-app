using Microsoft.EntityFrameworkCore;

namespace passbook_core_mvc_crud_app.Models
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) :base(options)
        {
            
        }

        public DbSet<Transactions> Transactions { get; set; }
    }
}
