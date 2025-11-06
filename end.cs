using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations; // <-- EZT ADD HOZZÁ!

namespace wshop
{
    public class Produs
    {
        [Key] // <-- Jelzi az adatbázisnak, hogy ez az elsődleges kulcs (és generálja automatikusan)
        public int Id { get; set; } // <-- Visszaállítva 'int'-re!

        [Required] // <-- Nem lehet üres
        [MaxLength(30)] // <-- Követelmény
        public string ProductName { get; set; }

        [MaxLength(500)] // <-- Követelmény
        public string ProductDescription { get; set; }

        public DateTime Intrare { get; set; }

        public DateTime Valabil { get; set; }

        public int Cant { get; set; }
    }

    public class MagazinDbContext : DbContext
    {
        public MagazinDbContext() : base("name=MagazinDbConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MagazinDbContext>());
        }
        public DbSet<Produs> Produse { get; set; }
    }
}