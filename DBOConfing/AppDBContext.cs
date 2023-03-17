using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Models.DBO;

namespace DBOConfing
{

    public partial class AppDBContext:DbContext
    {
        public DbSet<User> Users { get; set; }



        string ConnectionString =>  "";
        public AppDBContext() => Database.EnsureCreated();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=urData.base;");
        }
        

    }
}
