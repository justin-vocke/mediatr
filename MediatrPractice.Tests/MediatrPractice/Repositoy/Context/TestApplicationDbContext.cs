using MediatrPractice.Repository.Context;
using Microsoft.EntityFrameworkCore;


namespace MediatrPractice.Tests.MediatrPractice.Repositoy.Context
{
    public class TestApplicationDbContext: ApplicationDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseInMemoryDatabase("testDb")
                .EnableSensitiveDataLogging();

        }
    }
}
