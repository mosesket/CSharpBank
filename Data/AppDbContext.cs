using CSharpBank.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpBank.Data;

public class AppDbContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customers"); 
            entity.Property(c => c.FirstName).IsRequired();
            entity.Property(c => c.LastName).IsRequired();

            // relationships
            entity.HasMany(c => c.Accounts)
                .WithOne(a => a.Customer)
                .HasForeignKey(a => a.CustomerId);
        });

        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Accounts"); 
            entity.Property(a => a.CustomerId).IsRequired();
            entity.Property(a => a.AccountType).IsRequired();

            entity.HasOne(a => a.Customer)
                .WithMany(c => c.Accounts)
                .HasForeignKey(a => a.CustomerId);
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.ToTable("Transactions"); 
            entity.Property(t => t.AccountId).IsRequired();
            entity.Property(t => t.Amount).IsRequired();
            entity.Property(t =>  t.TransactionType).IsRequired();

            entity.HasOne(t => t.Account)
                .WithMany(a => a.Transactions)
                .HasForeignKey(t => t.AccountId);
        });
    }
}