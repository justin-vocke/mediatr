using MediatrPractice.Domain.Entities.Movies;
using Microsoft.EntityFrameworkCore;

namespace MediatrPractice.Repository.Context
{
    public class ApplicationDbContext: DbContext
    {
        

        public DbSet<Movie> Movies { get; set; }
    }
}
