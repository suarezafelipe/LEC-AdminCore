using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AdminCore.Migrations
{
    public class DbContextFactory : IDesignTimeDbContextFactory<MigrationsContext>
    {

        public MigrationsContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<MigrationsContext> builder = new DbContextOptionsBuilder<MigrationsContext>();
            builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LEC-DB-CORE;Trusted_Connection=True;", optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(MigrationsContext).GetTypeInfo().Assembly.GetName().Name));
            return new MigrationsContext(builder.Options);
        }
    }
}
