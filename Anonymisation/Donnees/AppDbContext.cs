using Anonymisation.Domaine;
using Microsoft.EntityFrameworkCore;

namespace Anonymisation.Donnees;

public class AppDbContext : DbContext
{
    public DbSet<Personne>? Personnes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // SQLite file "app.db" à la racine
        var path = Path.Combine(AppContext.BaseDirectory, "app.db");
        optionsBuilder.UseSqlite($"Data Source={path}");
        Console.WriteLine(path);
    }
}