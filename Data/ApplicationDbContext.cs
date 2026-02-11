using KAShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace KAShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
         




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //db for production
            optionsBuilder.UseSqlServer("Server=db40905.public.databaseasp.net; Database=db40905; User Id=db40905; Password=Tq7#-9Gob?4B; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;");
            //db for dev
            //optionsBuilder.UseSqlServer("Data Source=.;Database=mvc_13;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
