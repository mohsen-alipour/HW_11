using Microsoft.EntityFrameworkCore;
using HW_11.Models.Entity;
namespace HW_11.infrastructure.DataBase
{
    public class StoreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = .; Database = HW11; User Id = sa; Password = 123456;");
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Factor> _Factor { get; set; }
        public DbSet<Seller> _Seller { get; set; }
        public DbSet<Producer> _Producer { get; set; }

    }
}
