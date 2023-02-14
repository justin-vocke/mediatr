using MediatrPractice.Core.Enums;
using MediatrPractice.Domain.Entities.Movies;
using MediatrPractice.Tests.MediatrPractice.Repositoy.Context;

namespace MediatrPractice.Tests.Core
{
    
    public class BaseSetup
    {
        protected TestApplicationDbContext DbContext { get; set; }

        [SetUp]
        public virtual async Task SetUp()
        {
            DbContext = new TestApplicationDbContext();
            await PopulateTestDatabase();

            //put into base class in core
            //put in instance of db context
        }

        private async Task PopulateTestDatabase()
        {
            //put in some test code for in memory database.
            //just using ef core to populate.
            //refactor below to get rid of contructor instantiation.
            await DbContext.Movies.AddAsync(new Movie("test 1", "description 1", MovieGenre.Action, 7) { Id =1});
            await DbContext.Movies.AddAsync(new Movie("test 2", "description 2", MovieGenre.Horror, 6) { Id = 2});
            await DbContext.SaveChangesAsync();
        }


    }
}
