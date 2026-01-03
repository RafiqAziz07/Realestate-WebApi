using Microsoft.EntityFrameworkCore;
using RealEstate.Domain.Entities;
using System.Runtime;

namespace RealEstate.Presistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) 
            : base(options) { }

        public DataContext()  : base() { }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MyDB;User Id=sa;Password=Query202^@!;Encrypt=False;MultipleActiveResultSets=true",sqlServerOptionsAction =>{

                sqlServerOptionsAction.CommandTimeout(15);
                sqlServerOptionsAction.MigrationsHistoryTable("MigrationsHistory");
            });
            base.OnConfiguring(optionsBuilder);
            
        }

        public DbSet<City> Cities { get; set; }
        
    }
}
