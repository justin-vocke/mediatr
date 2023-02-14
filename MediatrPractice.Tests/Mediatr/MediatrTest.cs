using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MediatrPractice.Application.Movies.Commands.CreateMovie;
using MediatrPractice.Domain.DTOs.Responses.Movie;
using Moq;
using MediatrPractice.Core.Enums;
using MediatrPractice.Repository.Context;
using MediatrPractice.Domain.Entities.Movies;
using Microsoft.EntityFrameworkCore;
using MediatrPractice.Tests.Core;
using MediatrPractice.Application.Movies.Querie.GetMovie;
using Shouldly;

namespace MediatrPractice.Tests.Mediatr
{
    public class MediatrTest: BaseSetup
    {
        private GetMovieQueryHandler _queryHandler;
        [SetUp]
        public override async Task SetUp()
        {
            await base.SetUp();
            _queryHandler = new GetMovieQueryHandler(DbContext);
            
        }
        [Test]
        public async Task GetMovies_CreateMovieCommand_ReturnsAllMovies()
        {

            //Arrange
            var movieQuery = new GetMovieQuery(1);
            var movie = await _queryHandler.Handle(movieQuery, CancellationToken.None);


            //Act
            movie.Title.ShouldBe("test 1");
            movie.Description.ShouldBe("description 1");
        }
    }
}
