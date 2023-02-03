using MediatrPractice.Domain.Entities.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatrPractice.Services
{
    public interface ITestService
    {
        
            IEnumerable<Movie> GetAllItems();
            Movie Add(Movie newItem);
            Movie GetById(Guid id);
            void Remove(Guid id);
        
    }
}
