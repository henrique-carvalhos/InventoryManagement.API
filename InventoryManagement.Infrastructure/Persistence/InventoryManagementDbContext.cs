using InventoryManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Infrastructure.Persistence
{
    public class InventoryManagementDbContext : DbContext
    {
        public InventoryManagementDbContext(DbContextOptions<InventoryManagementDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração para Category
            modelBuilder.Entity<Category>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Category>()
                .Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Category>()
                .Property(i => i.Description)
                .IsRequired()
                .HasMaxLength(150);

            // Configuração para Customer
            modelBuilder.Entity<Customer>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Customer>()
                .Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Customer>()
                .Property(i => i.Email)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Customer>()
                .Property(i => i.Phone)
                .IsRequired()
                .HasMaxLength(15);

            // Configuração para Product
            modelBuilder.Entity<Product>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Product>()
                .Property(i => i.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Product>()
                .Property(i => i.Description)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Product>()
                .Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.IdCategory)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.IdSupplier)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuração para SaleItem
            modelBuilder.Entity<SaleItem>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<SaleItem>()
                .Property(i => i.UnitPrice)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<SaleItem>()
                .HasOne(si => si.Sale)
                .WithMany(s => s.SaleItems)
                .HasForeignKey(si => si.IdSale);

            modelBuilder.Entity<SaleItem>()
                .HasOne(si => si.Product)
                .WithMany()
                .HasForeignKey(si => si.IdProduct)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuração para Sale
            modelBuilder.Entity<Sale>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Sale>()
                .Property(i => i.TotalAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.IdCustomer)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuração para Supplier
            modelBuilder.Entity<Supplier>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Supplier>()
                .Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Supplier>()
                .Property(i => i.Email)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Supplier>()
                .Property(i => i.Address)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Supplier>()
                .Property(i => i.Contact)
                .IsRequired()
                .HasMaxLength(15);
        }
    }
}
