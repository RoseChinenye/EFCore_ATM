using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace ATM_DAL
{
    
    public class AtmDbContextFactory : IDesignTimeDbContextFactory<AtmDbContext>
    {
        public AtmDbContextFactory()
        {

        }

        public AtmDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AtmDbContext>();

            string connectionString = @"Data Source=(Paste your server name here);Initial Catalog=EFCoreAtmAppDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            optionsBuilder.UseSqlServer(connectionString, options =>
            {
                options.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
            });

            // Test the connection and print the connection status
            using (var dbContext = new AtmDbContext(optionsBuilder.Options))
            {
                try
                {
                    dbContext.Database.OpenConnection();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Database connection failed. Error: {ex.Message}");
                }
                finally
                {
                    dbContext.Database.CloseConnection();
                }
            }

            return new AtmDbContext(optionsBuilder.Options);
        }

    }
    
}
