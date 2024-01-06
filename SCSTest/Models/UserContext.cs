namespace SCSTest.Models;
using Microsoft.EntityFrameworkCore;

public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }
    private string DbPath { get; }
    
    public UserContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "users.db");
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}