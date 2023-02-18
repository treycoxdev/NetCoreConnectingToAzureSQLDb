using Microsoft.EntityFrameworkCore;
using NetCoreConnectingToAzureSQLDb.Models;

namespace NetCoreConnectingToAzureSQLDb.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Sample> Sample { get; set; }
    }
}