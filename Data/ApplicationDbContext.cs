using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using PalateParadise.Models;

namespace PalateParadise.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public static readonly string ApplicationDb = nameof(ApplicationDb).ToLower();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Reservation>? Reservations { get; set; }
    public DbSet<Menu>? Menus { get; set; }
    public DbSet<Beverage>? Beverages { get; set; }
    public DbSet<Order>? Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Reservation>()
            .HasKey(r => r.ReservationId);

        modelBuilder.Entity<Menu>()
            .HasKey(m => m.MenuId);

        modelBuilder.Entity<Beverage>()
            .HasKey(b => b.BeverageId);

        modelBuilder.Entity<Order>()
            .HasKey(o => o.OrderId);

        modelBuilder.Entity<Reservation>()
            .HasKey(r => r.ReservationId);

        modelBuilder.Entity<Reservation>()
            .HasOne(r => r.Menu)
            .WithMany()
            .HasForeignKey(r => r.MenuId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Reservation>()
            .HasOne(r => r.Beverage)
            .WithMany()
            .HasForeignKey(r => r.BeverageId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Order>()
            .HasKey(o => o.OrderId);

        modelBuilder.Entity<Menu>()
            .Property(m => m.Price)
            .HasColumnType("decimal(18,2)");
    }
}
