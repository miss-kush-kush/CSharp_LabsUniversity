using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakturaForms.Models;

namespace FakturaForms.DataContext
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace 'YourDatabaseName' with the name of the database you want to create
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=zutbd;Integrated Security=True;");
        }

        public DbSet<Faktura> Faktury { get; set; }
        public DbSet<Pozycja> Pozycje { get; set; }
    }
}
