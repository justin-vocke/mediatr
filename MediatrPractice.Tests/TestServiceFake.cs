using MediatrPractice.Domain.Entities.Movies;
using MediatrPractice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatrPractice.Core.Enums;

namespace MediatrPractice.Tests
{
    public class TestServiceFake : ITestService
    {
        private readonly List<Movie> _movies;
        public TestServiceFake()
        {
            _movies = new List<Movie>()
               {
                   new Movie("test1",
                       "action",
                       MovieGenre.Action,
                       7), 
                   new Movie("test2", "mystery", MovieGenre.Comedy, 5)
                   
               }; 
        }
        public Movie Add(Movie newItem)
        {
            _movies.Add(newItem);
            return newItem;
        }

        public IEnumerable<Movie> GetAllItems()
        {
            return _movies;
        }

        public Movie GetByTitle(string title)
        {
            return _movies.FirstOrDefault(x => x.Title == title);

        }

        public void Remove(string title)
        {
            var movie = _movies.FirstOrDefault(x => x.Title == title);
            _movies.Remove(movie);
        }
    }
}
