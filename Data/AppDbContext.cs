using Microsoft.EntityFrameworkCore;
using MobileDeviceManagement.Web.Models;
using MobileDeviceManagement.Web.Enums;  // ¡Esta línea es crucial!

namespace MobileDeviceManagement.Web.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Device> Devices { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Device>().HasData(
            new Device { Id = 1, Model = "iPhone 13", IMEI = "123456789012345", Status = DeviceStatus.Active }
        );
    }
}
