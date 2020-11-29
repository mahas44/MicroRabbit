using Microsoft.EntityFrameworkCore;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options): base(options)
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
        //     optionsBuilder.UseNpgsql("Host=localhost;Database=BankingDb;Username=postgres;Password=4891");

        public DbSet<Account> Accounts{get;set;}
    }
}