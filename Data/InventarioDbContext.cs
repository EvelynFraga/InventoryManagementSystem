
using Microsoft.EntityFrameworkCore;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Data;

public class InventarioDbContext : DbContext
{
    public DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=inventario.db");
    }

    protected override void OnModelCreating(
        ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>()
            .Property(p => p.Codigo)
            .UseCollation("NOCASE");

        modelBuilder.Entity<Producto>()
            .HasIndex(p => p.Codigo)
            .IsUnique();
    }
}
