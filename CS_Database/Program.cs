using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
class Adatbazis : DbContext
{
    // táblák felsorolása
    public DbSet<Egyik> Egyik { get; set; }
    public DbSet<Masik> Masik { get; set; }

    // kapcsolat definiálsa
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("server=localhost;database=test;user=root");
    }
}
