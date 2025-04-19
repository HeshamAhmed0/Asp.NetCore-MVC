

using System.Reflection;
using Demo.DataAccess.Data.Configrations;
using Demo.DataAccess.Repositories;

namespace Demo.DataAccess.Data.DbContexts
{
    public class ApplicationDbContext:DbContext
    { 

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Connection String");
        //}

        // this is Use For Apply Configrations 

        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // in this case will configur automatic
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            // this way is best
           modelBuilder.ApplyConfigurationsFromAssembly(typeof(DepartmentConfigration).Assembly);
        }


    }
}
