using MediatrPractice.Domain.Entities.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatrPractice.Services
{
    public class TestService : ITestService
    {
        public Movie Add(Movie newItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Movie GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
